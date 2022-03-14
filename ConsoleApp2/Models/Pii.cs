using Newtonsoft.Json;

namespace ConsoleApp2.Models;

public class Pii
{
    [JsonProperty("guest_last_name")]
    public string? GuestLastName { get; set; }
    
    [JsonProperty("guest_first_name")]
    public string? GuestFirstName { get; set; }
    
    [JsonProperty("guest_email")]
    public string? GuestEmail { get; set; }
    
    [JsonProperty("guest_phone")]
    public string? GuestPhone { get; set; }
    
    [JsonProperty("member_number")]
    public string? MemberNumber { get; set; }
}