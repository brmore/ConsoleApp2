using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ConsoleApp2.Attributes;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class ColumnAttribute : Attribute
{
    public string Name { get; private set; }
    public int Length { get; private set; }
    
    public bool NotNull { get; private set; }

    public ColumnAttribute(string name, int length = 0, bool notNull = false)
    {
        Name = name;
        Length = length;
        NotNull = notNull;
    }
}