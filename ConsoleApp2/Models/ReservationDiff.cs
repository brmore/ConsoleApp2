using System.ComponentModel.Design;
using System.Numerics;
using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;

namespace ConsoleApp2.Models;

public class ReservationDiff
{
    public long Id { get; private init; }
    public long BatchId { get; private init; }
    public string? ChainCode { get; private init; }
    public string? PropertyCode { get; private init; }
    public Reservation? OldValues { get; private init; }
    public Reservation? NewValues { get; private init; }
    public Pii Pii { get; private init; }
    
    public string[]? Diff { get; private init; }

    const string _connectString = "User ID=hapi_ows;Password=passw0rd;Host=localhost;Port=5432;Database=hapi_ows;";

    const string sql = 
@"select r.id, r.batch_id, p.chain_code, p.property_code, r.old_values, r.new_values, r.pii, r.diff 
    from reservation_diff r
    join property p on p.id = r.property_id
   where r.batch_id = :batch_id";

    private static async Task<ReservationDiff> Read(NpgsqlDataReader? reader)
    {
        if (reader == null) return null;

        return new ReservationDiff()
        {
            Id = reader.GetInt64(0),
            BatchId = reader.GetInt64(1),
            ChainCode = await reader.GetFieldValueAsync<string>(2),
            PropertyCode = await reader.GetFieldValueAsync<string>(3),
            OldValues = !await reader.IsDBNullAsync(4) ? await reader.GetFieldValueAsync<Reservation>(4) : null,
            NewValues = await reader.GetFieldValueAsync<Reservation>(5),
            Pii = !await reader.IsDBNullAsync(6) ? await reader.GetFieldValueAsync<Pii>(6) : null,
            Diff = !await reader.IsDBNullAsync(7) ? await reader.GetFieldValueAsync<string[]?>(7) : null
        };
    }
    
    public static async  Task<List<ReservationDiff>> Fetch(long batch_id)
    {
        var result = new List<ReservationDiff>();
        
        await using var connection = new NpgsqlConnection(_connectString);
        await using NpgsqlCommand command = new(sql, connection);
        command.Parameters.Add("batch_id", NpgsqlDbType.Bigint).Value = batch_id;
        try
        {
            await connection.OpenAsync();
            connection.TypeMapper.UseJsonNet(settings: new JsonSerializerSettings()
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Include
            });
    
            await using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                result.Add(await ReservationDiff.Read(reader));
            }

        }
        catch (Exception e)
        {
            throw;
        }
        finally
        {
            await connection.CloseAsync();
        }

        return result;
    }
}