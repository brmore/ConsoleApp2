using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using ConsoleApp2.Attributes;
using ConsoleApp2.Extensions;
using ConsoleApp2.Models;
using CsvHelper;
using CsvHelper.Configuration;
using ConsoleApp2.Extensions;
using Hapi.SDK.Core.Models.v3;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Npgsql;
using Reservation = ConsoleApp2.Models.Reservation;

const string _connectString = "User ID=hapi_ows;Password=passw0rd;Host=localhost;Port=5432;Database=hapi_ows;";
const string _path = "/Users/bmore/Developer/dotnet/scrap/ConsoleApp2/ConsoleApp2/Samples/hapi_resv_interval11524108.txt";

// var reservations = GetReservations();
// reservations.ForEach(r => r.Chain = "IHG");
//
// var batch_id = await Save<Reservation>(reservations);
// Console.WriteLine(batch_id);

var diffs = await ReservationDiff.Fetch(41);
foreach (var diff in diffs)
{
    var v3 = diff.ToV3(ReservationNotificationType.UPDATE, ReservationStatus.RESERVED);
    Console.WriteLine(JsonConvert.SerializeObject(v3));
}

Console.WriteLine(diffs.Count);

IEnumerable<string> Rows<T>(List<T> ts, PropertyInfo[] ps)
{
    var rows = new List<string>();

    foreach(var r in ts)
    {
        var values = new List<string>();
        foreach (var p in ps)
        {
            if (p.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault() is not ColumnAttribute) continue;
        
            var value = p.GetValue(r);
            switch (value)
            {
                case string s:
                    values.Add(s.ToSqlText());
                    break;
                case DateOnly:
                    values.Add(((DateOnly?)value).ToSqlText());
                    break;
                case TimeOnly:
                    values.Add(((TimeOnly?)value).ToSqlText());
                    break;
                case null:
                    values.Add("null");
                    break;
                default:
                    values.Add(value.ToString());
                    break;
            }
        }
        rows.Add($"({string.Join(',',values)})");
    }

    return rows;
}

IEnumerable<string> ColumnNames(IEnumerable<PropertyInfo> ps)
{
    var list = new List<string>();
    foreach (var p in ps)
    {
        if (p.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault() is not ColumnAttribute a) continue;
        list.Add(a.Name);
    }
    return list;
}

async Task<long?> Save<T>(List<T> ts)
{
    var ps = typeof(T).GetProperties();
    var columns = string.Join(',', ColumnNames(ps));
    var rows = string.Join(",\n", Rows(ts, ps));

    var sql = $"insert into temp_{typeof(T).Name.ToLower()} ({columns}) values\n{rows};";

    await using NpgsqlConnection connection = new NpgsqlConnection(_connectString);
    await using NpgsqlCommand command = new("CALL p_create_temp_resv_table()", connection);
    try
    {
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
        command.CommandText = sql;
        await command.ExecuteNonQueryAsync();
        command.CommandText = "select * from f_upsert_reservation_from_temp()";
        var batchId = await command.ExecuteScalarAsync();
        return batchId as long? ?? (long?)0;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.ToString());
        throw;
    }
    finally
    {
        await connection.CloseAsync();
    }
}

string Scaffold<T>()
{
    var type = typeof(T);
    var columns = (from p in typeof(Reservation).GetProperties()
        let a = p.GetCustomAttributes(typeof(ColumnAttribute), true).First() as ColumnAttribute
        let propertyType = Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType
        select $"\t{a.Name} {p.SqlType()}{p.SqlLength()}{p.SqlNotNull()}").ToList();
    return $"create temp table temp_{type.Name.ToLower()} (\n{string.Join(",\n", columns)}\n);";
}

List<Reservation> GetReservations()
{
    using var reader = new StreamReader(_path);
    using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = "|"
    });
    return csv.GetRecords<Reservation>().ToList();
}