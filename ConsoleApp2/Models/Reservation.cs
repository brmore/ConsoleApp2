using System;
using System.Collections.Generic;
using System.ComponentModel;
using ConsoleApp2.Attributes;
using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json;

namespace ConsoleApp2.Models
{
    public class Reservation
    {
        [Ignore]
        [Column("chain_code", 10, true)]
        [JsonIgnore]
        public string? Chain { get; set; }

        [Name("RESORT")] 
        [Column("property_code", 10, true)]
        [JsonIgnore]
        public string Resort { get; set; }
     
        [Ignore]
        [JsonProperty("property_id")]
        public int? PropertyId { get; set; }

        [Name("INSERT_DATE")] 
        [Column("insert_date")]
        [JsonIgnore]
        public DateOnly? InsertDate { get; set; }
        
        [Name("ACTION_INSTANCE_ID")]
        [Column("action_instance_id")]
        [JsonIgnore]
        public long? ActionInstanceId { get; set; }
        
        [Name("ACTION_TYPE")] 
        [Column("action_type", 128, true)]
        [JsonIgnore]
        public string? ActionType { get; set; }
        
        [Name("RESV_NAME_ID")] 
        [Column("resv_name_id")]
        [JsonProperty("resv_name_id")]
        public long? ResvNameId { get; set; }
        
        [Name("TRUNC_ARRIVAL")] 
        [Column("trunc_arrival")]
        [JsonProperty("trunc_arrival")]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? TruncArrival { get; set; }
        
        [Name("ARRIVAL_TIME")] 
        [Column("arrival_time")]
        [JsonProperty("arrival_time")]
        [JsonConverter(typeof(TimeOnlyJsonConverter))]
        public TimeOnly? ArrivalTime { get; set; }
        
        [Name("TRUNC_DEPARTURE")] 
        [Column("trunc_departure")]
        [JsonProperty("trunc_departure")]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? TruncDeparture { get; set; }
        
        [Name("DEPARTURE_TIME")] 
        [Column("departure_time")]
        [JsonProperty("departure_time")]
        [JsonConverter(typeof(TimeOnlyJsonConverter))]
        public TimeOnly? DepartureTime { get; set; }
        
        [Name("ADULTS")] 
        [Column("adults")]
        [JsonProperty("adults")]
        public int? Adults { get; set; }
        
        [Name("CHILDREN")] 
        [Column("children")]
        [JsonProperty("children")]
        public int? Children { get; set; }
        
        [Name("ROOM_CATEGORY_LABEL")] 
        [Column("room_category_label", 20)]
        [JsonProperty("room_category_label")]
        public string? RoomCategoryLabel { get; set; }
        
        [Name("ROOM")] 
        [Column("room", 20)]
        [JsonProperty("room")]
        public string? Room { get; set; }
        
        [Name("COMPANY_NAME")] 
        [Column("company_name", 256)]
        [JsonProperty("company_name")]
        public string? CompanyName { get; set; }
        
        [Name("COMPANY_ID")] 
        [Column("company_id")]
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }
        
        [Name("TRAVEL_AGENT_NAME")] 
        [Column("travel_agent_name", 256)]
        [JsonProperty("travel_agent_name")]
        public string? TravelAgentName { get; set; }
        
        [Name("TRAVEL_AGENT_ID")] 
        [Column("travel_agent_id")]
        [JsonProperty("travel_agent_id")]
        public long? TravelAgentId { get; set; }
        
        [Name("RESV_STATUS")] 
        [Column("resv_status", 20)]
        [JsonProperty("resv_status")]
        public string? ResvStatus { get; set; }
        
        [Name("COMPUTED_RESV_STATUS")]
        [Column("computed_resv_status", 20)]
        [JsonProperty("computed_resv_status")]
        public string? ComputedResvStatus { get; set; }
        
        [Name("BLOCK_CODE")] 
        [Column("block_code", 20)]
        [JsonProperty("block_code")]
        public string? BlockCode { get; set; }

        [Name("IS_SHARED_YN"), BooleanTrueValues("Y"), BooleanFalseValues("N")]
        [Column("is_shared")]
        [JsonProperty("is_shared")]
        public bool? IsSharedYn { get; set; }

        [Name("SHARE_ID")] 
        [Column("share_id")]
        [JsonProperty("share_id")]
        public long? ShareId { get; set; }
        
        [Name("CONFIRMATION_NO")]
        [Column("confirmation_no", 20)]
        [JsonProperty("confirmation_no")]
        public string? ConfirmationNo { get; set; }
        
        [Name("EXTERNAL_REFERENCE")] 
        [Column("external_reference", 20)]
        [JsonProperty("external_reference")]
        public string? ExternalReference { get; set; }
        
        [Name("SPECIALS")] 
        [Column("specials", 256)]
        [JsonProperty("specials")]
        public string? Specials { get; set; }
        
        [Name("CURRENCY_CODE")]
        [Column("currency_code", 10)]
        [JsonProperty("currency_code")]
        public string? CurrencyCode { get; set; }

        [Name("POSTING_ALLOWED_YN"), BooleanTrueValues("Y"), BooleanFalseValues("N")]
        [Column("posting_allowed")]
        [JsonProperty("posting_allowed")]
        public bool? PostingAllowedYn { get; set; }

        [Name("MULTIPLE_RATE_CODE_YN"), BooleanTrueValues("Y"), BooleanFalseValues("N")]
        [Column("multiple_rate_code")]
        [JsonProperty("multiple_rate_code")]
        public bool? MultipleRateCodeYn { get; set; }

        [Name("RATE_CODE")] 
        [Column("rate_code", 20)]
        [JsonProperty("rate_code")]
        public string? RateCode { get; set; }
        
        [Name("SHARE_AMOUNT")] 
        [Column("share_amount")]
        [JsonProperty("share_amount")]
        public decimal? ShareAmount { get; set; }
        
        [Name("GUEST_TITLE")] 
        [Column("guest_title", 20)]
        [JsonProperty("guest_title")]
        public string? GuestTitle { get; set; }

        [Name("GUEST_FIRST_NAME")]
        [Column("guest_first_name", 256)]
        [JsonIgnore]
        public string? GuestFirstName { get; set; }

        [Name("GUEST_LAST_NAME")]
        [Column("guest_last_name", 256)]
        [JsonIgnore]
        public string? GuestLastName { get; set; }

        [Name("GUEST_VIP")]
        [Column("guest_vip", 20)]
        [JsonProperty("guest_vip")]
        public string? GuestVip { get; set; }
        
        [Name("GUEST_LANGUAGE")]
        [Column("guest_language", 10)]
        [JsonProperty("guest_language")]
        public string? GuestLanguage { get; set; }
        
        [Name("GUEST_NAME_ID")] 
        [Column("guest_name_id")]
        [JsonProperty("guest_name_id")]
        public long? GuestNameId { get; set; }
        
        [Name("MEMBERSHIP_TYPE")]
        [Column("membership_type", 20)]
        [JsonProperty("membership_type")]
        public string? MembershipType { get; set; }
        
        [Name("MEMBERSHIP_LEVEL")] 
        [Column("membership_level", 20)]
        [JsonProperty("membership_level")]
        public string? MembershipLevel { get; set; }

        [Name("MEMBERSHIP_NUMBER")]
        [JsonIgnore]
        [Column("membership_number", 128)]
        public string? MembershipNumber { get; set; }

        [Name("GUEST_PHONE")]
        [JsonIgnore]
        [Column("guest_phone", 256)]
        public string? GuestPHone { get; set; }

        [Name("GUEST_EMAIL")]
        [JsonIgnore]
        [Column("guest_email", 256)]
        public string? GuestEmail { get; set; }

        [Name("PREFERENCES")]
        [Column("preferences", 256)]
        [JsonProperty("preferences")]
        public string? Preferences { get; set; }
        
        [Ignore]
        [JsonProperty("insert_date")]
        public DateTime? CreateDate { get; set; }
        
        [Ignore]
        [JsonProperty("update_date")]
        public DateTime? UpdateDate { get; set; }
        
        [Ignore]
        [JsonProperty("inactive_date")]
        public DateTime? InactiveDate { get; set; }
    }
}