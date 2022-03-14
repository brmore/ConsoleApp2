using System.Globalization;
using Newtonsoft.Json;

namespace ConsoleApp2.Attributes;

public class TimeOnlyJsonConverter : JsonConverter<TimeOnly?>
{
    private const string TimeFormat = "HH:mm:ss.FFFFFFF";

    public override TimeOnly? ReadJson(JsonReader reader, Type objectType, TimeOnly? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        return !string.IsNullOrEmpty((string) reader.Value)
            ? TimeOnly.ParseExact((string) reader.Value, TimeFormat, CultureInfo.InvariantCulture)
            : null;
    }

    public override void WriteJson(JsonWriter writer, TimeOnly? value, JsonSerializer serializer)
    {
        if (!value.HasValue) return;
        writer.WriteValue(value.Value.ToString(TimeFormat, CultureInfo.InvariantCulture));
    }
}