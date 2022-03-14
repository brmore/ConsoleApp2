using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ConsoleApp2.Attributes;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class SqlIgnoreAttribute : Attribute
{
    //
}