namespace ConsoleApp2.Attributes;

public class DateFormatConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
{
    public DateFormatConverter()
    {
        DateTimeFormat = "yyyy-MM-dd";
    }
}