using System.Reflection;
using ConsoleApp2.Attributes;

namespace ConsoleApp2.Extensions;

public static class SqlTypeExtensions
{
    private static readonly IDictionary<Type, string> _typeDictionary;

    static SqlTypeExtensions()
    {
        _typeDictionary = new Dictionary<Type, string>()
        {
            {typeof(string), "varchar"},
            {typeof(long), "bigint"},
            {typeof(int), "int"},
            {typeof(DateOnly), "date"},
            {typeof(TimeOnly), "time"},
            {typeof(bool), "bool"},
            {typeof(decimal), "decimal"}
        };
    }

    public static string ToSqlText(this string? s)
    {
        return !string.IsNullOrEmpty(s) ? $"'{s}'" : "null";
    }
    
    public static string ToSqlText(this DateOnly? dateOnly)
    {
        return dateOnly.HasValue ? dateOnly.Value.ToString("\"'\"yyyy-MM-dd\"'\"") : "null";
    }
    
    public static string ToSqlText(this TimeOnly? timeOnly)
    {
        return timeOnly.HasValue ? timeOnly.Value.ToString("\"'\"HH:mm:ss\"'\"") : "null";
    }

    public static string? SqlNotNull(this PropertyInfo p)
    {
        if (p.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault() is not ColumnAttribute a) return null;
        return p.PropertyType == typeof(string)  && !a.NotNull || Nullable.GetUnderlyingType(p.PropertyType) != null ? null : " not null";
    }

    public static string? SqlType(this PropertyInfo p)
    {
        return _typeDictionary[Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType];
    }

    public static string? SqlLength(this PropertyInfo p)
    {
        if (p.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault() is not ColumnAttribute a) return null;
        var t = Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType;
        return t == typeof(string) ? $"({a.Length})" : null;
    }
}