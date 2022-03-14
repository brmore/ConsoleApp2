using ConsoleApp2.Attributes;

namespace Hapi.SDK.Core.Models.v3
{
    using Newtonsoft.Json;
    using System = global::System;
    
    /// <summary>The accounting details associated with the profile</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AccountingDetails
    {
        /// <summary>The company tax id</summary>
        [Newtonsoft.Json.JsonProperty("taxId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TaxId { get; set; }

        /// <summary>The electronic invoice id</summary>
        [Newtonsoft.Json.JsonProperty("electronicInvoiceId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectronicInvoiceId { get; set; }

        /// <summary>The account receivable identifier for the profile</summary>
        [Newtonsoft.Json.JsonProperty("accountReceivableNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountReceivableNumber { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>A place holder for additional data associated with the object</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AdditionalData
    {
        /// <summary>The category associated with the value</summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>The type associated with the value</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>The code associated with the value</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>The value for the custom object</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The price definition for the additional item</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AdditionalItemPrice
    {
        /// <summary>Specifies the type for the additional item such as bed or cot</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; }

        /// <summary>The price amount excluding all taxes associated with the additional item types</summary>
        [Newtonsoft.Json.JsonProperty("amountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountBeforeTax { get; set; }

        /// <summary>The price amount including all taxes associated with the additional item types</summary>
        [Newtonsoft.Json.JsonProperty("amountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountAfterTax { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The price for the additional occupant</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AdditionalOccupantsPrice
    {
        /// <summary>The occupant type associated with the price</summary>
        [Newtonsoft.Json.JsonProperty("occupantsType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AdditionalOccupantsPriceOccupantsType OccupantsType { get; set; }

        /// <summary>The price amount</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>The price amount excluding all taxes associated with the unit types and the occupancy</summary>
        [Newtonsoft.Json.JsonProperty("amountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountBeforeTax { get; set; }

        /// <summary>The price amount including all taxes associated with the unit types and the occupancy</summary>
        [Newtonsoft.Json.JsonProperty("amountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountAfterTax { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The address details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Address
    {
        /// <summary>The address type such as Private, Business, HQ, Shipping</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>The first line for the address</summary>
        [Newtonsoft.Json.JsonProperty("line1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Line1 { get; set; }

        /// <summary>The second line for the address</summary>
        [Newtonsoft.Json.JsonProperty("line2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Line2 { get; set; }

        /// <summary>The third line for the address</summary>
        [Newtonsoft.Json.JsonProperty("line3", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Line3 { get; set; }

        /// <summary>The forth line for the address</summary>
        [Newtonsoft.Json.JsonProperty("line4", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Line4 { get; set; }

        /// <summary>The postal code</summary>
        [Newtonsoft.Json.JsonProperty("postalCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        /// <summary>The address city name</summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }

        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public State State { get; set; }

        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Country Country { get; set; }

        /// <summary>When true, this is the primary address for the profile</summary>
        [Newtonsoft.Json.JsonProperty("isPrimary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPrimary { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>A notification associated with the reservation</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Alert
    {
        /// <summary>The event associated with the alert</summary>
        [Newtonsoft.Json.JsonProperty("event", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Event { get; set; }

        /// <summary>Identifies the alert</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>The alert description</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Availability
    {
        [Newtonsoft.Json.JsonProperty("propertyDetails", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public PropertyDetails PropertyDetails { get; set; } = new PropertyDetails();

        /// <summary>A collection of rate availability and restrictions</summary>
        [Newtonsoft.Json.JsonProperty("availabilityDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<AvailabilityDetails> AvailabilityDetails { get; set; } = new System.Collections.ObjectModel.Collection<AvailabilityDetails>();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The room and rate availability details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AvailabilityDetails
    {
        /// <summary>The start date for the restriction. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for the restriction. End date is inclusive</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>A collection of unit types for which the restrictions apply</summary>
        [Newtonsoft.Json.JsonProperty("unitTypes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<UnitType> UnitTypes { get; set; }

        /// <summary>A collection of rate plans for which the rate availability restrictions apply</summary>
        [Newtonsoft.Json.JsonProperty("ratePlans", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RatePlan> RatePlans { get; set; }

        [Newtonsoft.Json.JsonProperty("daysOfWeek", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DaysOfWeek DaysOfWeek { get; set; }

        /// <summary>A collection of booking rules associated with the unit types and / or the rate plans</summary>
        [Newtonsoft.Json.JsonProperty("bookingRules", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<BookingRule> BookingRules { get; set; } = new System.Collections.ObjectModel.Collection<BookingRule>();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The base price details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BasePrice
    {
        /// <summary>The occupancy definition associated with the price</summary>
        [Newtonsoft.Json.JsonProperty("occupants", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Occupants> Occupants { get; set; }

        /// <summary>The price amount associated with the unit types and the occupancy</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>The price amount excluding all taxes associated with the unit types and the occupancy</summary>
        [Newtonsoft.Json.JsonProperty("amountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountBeforeTax { get; set; }

        /// <summary>The price amount including all taxes associated with the unit types and the occupancy</summary>
        [Newtonsoft.Json.JsonProperty("amountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountAfterTax { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Block
    {
        [Newtonsoft.Json.JsonProperty("propertyDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public PropertyDetails PropertyDetails { get; set; } = new PropertyDetails();

        /// <summary>Identifies the type of notification. Available values: NEW ; UPDATE ; DELETE ; CANCEL ; DELTA ; OVERLAY ; UNKNOWN </summary>
        [Newtonsoft.Json.JsonProperty("notificationType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BlockNotificationType? NotificationType { get; set; }

        /// <summary>The Hapi unique id for the block</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>A collection of external ids to identify the record on other systems</summary>
        [Newtonsoft.Json.JsonProperty("referenceIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<ReferenceId> ReferenceIds { get; set; } = new System.Collections.ObjectModel.Collection<ReferenceId>();

        /// <summary>A code that identifies the block</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>The block name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The block type such as allotment, group.. </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>The type for the inventory such as ELASTIC, NON_ELASTIC, SELL_LIMIT</summary>
        [Newtonsoft.Json.JsonProperty("blockInventoryType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockInventoryType { get; set; }

        /// <summary>The start date for the block. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for the block</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>Specifies the start date for the shoulder duration</summary>
        [Newtonsoft.Json.JsonProperty("startShoulderDuration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? StartShoulderDuration { get; set; }

        /// <summary>Specifies the end date for the shoulder duration</summary>
        [Newtonsoft.Json.JsonProperty("endShoulderDuration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? EndShoulderDuration { get; set; }

        /// <summary>The date when the non picked up rooms of the block will be released if not reserved</summary>
        [Newtonsoft.Json.JsonProperty("absoluteCutoffDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? AbsoluteCutoffDate { get; set; }

        /// <summary>This field allows for a dynamic cutoff date to be set This is particularly useful in the case where the block is a long-term block where reservations can be booked for any portion of the block</summary>
        [Newtonsoft.Json.JsonProperty("releaseDaysBeforeStayDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ReleaseDaysBeforeStayDate { get; set; }

        /// <summary>The Status for the block</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Status { get; set; }

        /// <summary>The date and time the block was created</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>The user or system who created the block</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The date and time the block was last modified, if block has not been modified use date created</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>The user or system who last modified the block</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }

        [Newtonsoft.Json.JsonProperty("cancellationDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CancellationDetails CancellationDetails { get; set; }

        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public Currency Currency { get; set; }

        /// <summary>A collection of requested deposits</summary>
        [Newtonsoft.Json.JsonProperty("requestedDeposits", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Deposit> RequestedDeposits { get; set; }

        /// <summary>Identifies how the block is guaranteed</summary>
        [Newtonsoft.Json.JsonProperty("guaranteeCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GuaranteeCode { get; set; }

        [Newtonsoft.Json.JsonProperty("paymentMethod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>Defines how individual reservations should be booked against the block</summary>
        [Newtonsoft.Json.JsonProperty("reservationPickUpMethod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReservationPickUpMethod { get; set; }

        /// <summary>A collection of inventories associated with the block</summary>
        [Newtonsoft.Json.JsonProperty("blockInventories", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BlockInventory> BlockInventories { get; set; }

        /// <summary>A collection of segmentations for the block</summary>
        [Newtonsoft.Json.JsonProperty("segmentations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Segmentation> Segmentations { get; set; }

        /// <summary>A collection of comments associated with the block</summary>
        [Newtonsoft.Json.JsonProperty("comments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Comment> Comments { get; set; }

        /// <summary>A collection of profiles associated with the block</summary>
        [Newtonsoft.Json.JsonProperty("profiles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Profile> Profiles { get; set; }

        /// <summary>A collection of additional data for the reservation</summary>
        [Newtonsoft.Json.JsonProperty("additionalData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalData> AdditionalData { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        public EnvelopeOfBlock ToEnvelope()
        {
            return new EnvelopeOfBlock()
            {
                Data = this,
                ReceivedDateTime = System.DateTime.UtcNow,
                CreatedDateTime = System.DateTime.UtcNow,
                LastModifiedDateTime = System.DateTime.UtcNow
            };
        }
    }


    /// <summary>The block inventory by unit type</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BlockInventory
    {
        [Newtonsoft.Json.JsonProperty("unitType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public UnitType UnitType { get; set; } = new UnitType();

        /// <summary>A collection of block inventory details</summary>
        [Newtonsoft.Json.JsonProperty("inventoryDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BlockInventoryDetails> InventoryDetails { get; set; }

        /// <summary>A collection of block rates</summary>
        [Newtonsoft.Json.JsonProperty("rates", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BlockRate> Rates { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The number of units by inventory count type</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BlockInventoryCount
    {
        /// <summary>The inventory type associated with the inventory details</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BlockInventoryCountType Type { get; set; }

        /// <summary>The unit count associated with the inventory type</summary>
        [Newtonsoft.Json.JsonProperty("unitsCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UnitsCount { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The number of units by inventory count type and occupant type</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BlockInventoryCountByOccupants
    {
        /// <summary>The occupancy definition associated with the inventory count</summary>
        [Newtonsoft.Json.JsonProperty("occupants", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Occupants> Occupants { get; set; }

        /// <summary>The inventory type associated with the inventory details</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BlockInventoryCountByOccupantsType Type { get; set; }

        /// <summary>The unit count associated with the inventory type</summary>
        [Newtonsoft.Json.JsonProperty("unitsCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UnitsCount { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The block inventory count details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BlockInventoryDetails
    {
        /// <summary>The start date for which the values in the array apply</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for which the values in the array apply</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>The date when the non picked up rooms of the block will be released if not reserved. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("absoluteCutoffDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? AbsoluteCutoffDate { get; set; }

        /// <summary>This field allows for a dynamic cutoff date to be set. This is particularly useful in the case where the block contains mini-blocks or sets of inventory within it, or where the block is a long-term block where reservations can be booked for any portion of the block</summary>
        [Newtonsoft.Json.JsonProperty("releaseDaysBeforeStayDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ReleaseDaysBeforeStayDate { get; set; }

        /// <summary>The inventory counts associated with the unit types</summary>
        [Newtonsoft.Json.JsonProperty("blockInventoryCounts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<BlockInventoryCount> BlockInventoryCounts { get; set; } = new System.Collections.ObjectModel.Collection<BlockInventoryCount>();

        /// <summary>The inventory counts per occupants associated with the unit types</summary>
        [Newtonsoft.Json.JsonProperty("blockInventoryCountsByOccupants", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BlockInventoryCountByOccupants> BlockInventoryCountsByOccupants { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The price details associated with the block inventory</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BlockRate
    {
        /// <summary>The start date for which the values in the array apply</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for which the values in the array apply</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>The rate plan code</summary>
        [Newtonsoft.Json.JsonProperty("ratePlanCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RatePlanCode { get; set; }

        /// <summary>A collection of base prices associated with the rate</summary>
        [Newtonsoft.Json.JsonProperty("basePrices", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<BasePrice> BasePrices { get; set; } = new System.Collections.ObjectModel.Collection<BasePrice>();

        /// <summary>A collection of prices for additional occupants</summary>
        [Newtonsoft.Json.JsonProperty("additionalOccupantsPrices", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalOccupantsPrice> AdditionalOccupantsPrices { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }


    /// <summary>The details for the booked unit, generally associated with the rates</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class BookedReservationUnitDetails
    {
        /// <summary>The start date for which the values in the array apply</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for which the values in the array apply</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>Number of reserved unit</summary>
        [Newtonsoft.Json.JsonProperty("unitCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UnitCount { get; set; }

        /// <summary>Number of occupied physical unit. e.g: the occupied unit count will be higher in case of connected rooms that are reserved as a suite</summary>
        [Newtonsoft.Json.JsonProperty("physicalUnitCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PhysicalUnitCount { get; set; }

        /// <summary>Identifies the unit class</summary>
        [Newtonsoft.Json.JsonProperty("unitClassCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitClassCode { get; set; }

        /// <summary>The name for the unit class such as room, bed, apartment...</summary>
        [Newtonsoft.Json.JsonProperty("unitClassName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitClassName { get; set; }

        /// <summary>Identifies category associated with the unit type</summary>
        [Newtonsoft.Json.JsonProperty("unitCategoryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitCategoryCode { get; set; }

        /// <summary>The unit category name</summary>
        [Newtonsoft.Json.JsonProperty("unitCategoryName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitCategoryName { get; set; }

        /// <summary>Identifies the unit type</summary>
        [Newtonsoft.Json.JsonProperty("unitTypeCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string UnitTypeCode { get; set; }

        /// <summary>The unit type name</summary>
        [Newtonsoft.Json.JsonProperty("unitTypeName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitTypeName { get; set; }

        /// <summary>A collection of extra beds associated to the unit</summary>
        [Newtonsoft.Json.JsonProperty("extraBeds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ExtraBed> ExtraBeds { get; set; }

        /// <summary>When true, the unit is to be considered in forecast statistics</summary>
        [Newtonsoft.Json.JsonProperty("isForecasted", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsForecasted { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The restriction details associated with the rate plan or the unit</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BookingRule
    {
        /// <summary>The restriction or booking rule</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BookingRuleType Type { get; set; }

        /// <summary>The value associated with the booking rule type</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Value { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The cancellation details if the reservation or the block has been cancelled</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class CancellationDetails
    {
        /// <summary>When the reservation or the block was cancelled</summary>
        [Newtonsoft.Json.JsonProperty("cancellationDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? CancellationDateTime { get; set; }

        /// <summary>The business date that the reservation or the block was cancelled</summary>
        [Newtonsoft.Json.JsonProperty("cancellationBusinessDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? CancellationBusinessDate { get; set; }

        /// <summary>The user or the system that cancelled the reservation or the block</summary>
        [Newtonsoft.Json.JsonProperty("cancelledBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CancelledBy { get; set; }

        /// <summary>The cancellation reason's identifier or short name</summary>
        [Newtonsoft.Json.JsonProperty("cancellationReasonCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CancellationReasonCode { get; set; }

        /// <summary>The description for the cancellation reason</summary>
        [Newtonsoft.Json.JsonProperty("cancellationReasonText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CancellationReasonText { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The cancellation rule details, generally associated with the rate plan</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CancellationPolicy
    {
        /// <summary>The cancellation policy code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>The cancellation policy name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The description policy name</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ChildrenDetails 
    {
        /// <summary>The children count associated with the age</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Always)]
        public int Count { get; set; }
    
        /// <summary>The age associated with the count</summary>
        [Newtonsoft.Json.JsonProperty("age", Required = Newtonsoft.Json.Required.Always)]
        public int Age { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The classification details associated with the guest</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Classification
    {
        /// <summary>The classification code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The comment details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Comment
    {
        /// <summary>The context for the comment to define when the comment is relevant</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>Title of the comment</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>The full comment text</summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Text { get; set; }

        /// <summary>The Hapi property code</summary>
        [Newtonsoft.Json.JsonProperty("propertyCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PropertyCode { get; set; }

        /// <summary>The date and time the comment was created</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>The user or system who created the comment</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The date and time the comment was last modified, if the comment has not been modified use date created</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>The user or system who last modified the comment</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }

        /// <summary>When true, the comment can be viewed or shared with the guest</summary>
        [Newtonsoft.Json.JsonProperty("isGuestViewable", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsGuestViewable { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Commission
    {
        /// <summary>The identifier for the commission</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>The commission percent associated to the commission code</summary>
        [Newtonsoft.Json.JsonProperty("commissionPercent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? CommissionPercent { get; set; }

        /// <summary>The commission payable amount</summary>
        [Newtonsoft.Json.JsonProperty("commissionAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? CommissionAmount { get; set; }

        /// <summary>The commission payable amount excluding all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("commissionAmountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? CommissionAmountBeforeTax { get; set; }

        /// <summary>The commission payable amount including all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("commissionAmountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? CommissionAmountAfterTax { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The consent details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Consent
    {
        /// <summary>The activity category that the guest has given consent such as ThirdParty, Marketing, Invoice</summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>The type or media associated with the category such as SMS, Phone, Email</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>When true, the guest has given consent for the activity defined in the type</summary>
        [Newtonsoft.Json.JsonProperty("isAllowed", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsAllowed { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The contact details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactDetails
    {
        /// <summary>The type associated with the category for the contact detail, such as Mobile, Linkedin etc</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>The value associated to the contact detail category</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Value { get; set; }

        /// <summary>The category for the contact details</summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ContactDetailsCategory Category { get; set; }

        /// <summary>When true, indicates this is the preferred contact to be used</summary>
        [Newtonsoft.Json.JsonProperty("isPrimary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPrimary { get; set; }

        /// <summary>When true, the contact details have been validated and can be used</summary>
        [Newtonsoft.Json.JsonProperty("isVerified", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsVerified { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Contact associated with the profile</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactPerson
    {
        /// <summary>A collection of names associated to the profile</summary>
        [Newtonsoft.Json.JsonProperty("names", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PersonName> Names { get; set; }

        /// <summary>The department associated to the contact person</summary>
        [Newtonsoft.Json.JsonProperty("department", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Department { get; set; }

        /// <summary>The position for the contact person</summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>A collection of contacts associated to the profile</summary>
        [Newtonsoft.Json.JsonProperty("contactDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContactDetails> ContactDetails { get; set; }

        /// <summary>When true, indicates this is the primary contact</summary>
        [Newtonsoft.Json.JsonProperty("isPrimary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPrimary { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The corporate details associated with the guest</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CorporateDetails
    {
        /// <summary>The company associated with the guest</summary>
        [Newtonsoft.Json.JsonProperty("companyName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        /// <summary>The position associated with the company and the department for the guest</summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>The department associated with the position</summary>
        [Newtonsoft.Json.JsonProperty("department", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Department { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The country identifiers</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Country
    {
        /// <summary>The country code. Formatted using ISO 3166</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>The country name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The format for the country code</summary>
        [Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CountryFormat? Format { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Cross-references to link Hapi object with records from other systems</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CrossReference
    {
        /// <summary>The Hapi unique id of some object like Reservation, Profile, Guest, etc.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>IDs to identify the record on other systems</summary>
        [Newtonsoft.Json.JsonProperty("referenceIds", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<ReferenceId> ReferenceIds { get; set; } = new System.Collections.ObjectModel.Collection<ReferenceId>();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Provides a currency code and decimal places to reflect the currency in which an amount may be expressed</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Currency
    {
        /// <summary>An ISO 4217 (3) alpha character code that specifies a monetary unit</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>Number of decimal places for a particular currency</summary>
        [Newtonsoft.Json.JsonProperty("decimalPlaces", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? DecimalPlaces { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        public Currency(string code) { Code = code; }
        public Currency() { }
    }

    /// <summary>Defines on which days of the week the value applies. If not informed, it is assumed that the value applies for all the days</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class DaysOfWeek
    {
        /// <summary>When true, the value applies on this day</summary>
        [Newtonsoft.Json.JsonProperty("monday", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Monday { get; set; }

        /// <summary>When true, the value applies on this day</summary>
        [Newtonsoft.Json.JsonProperty("tuesday", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Tuesday { get; set; }

        /// <summary>When true, the value applies on this day</summary>
        [Newtonsoft.Json.JsonProperty("wednesday", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Wednesday { get; set; }

        /// <summary>When true, the value applies on this day</summary>
        [Newtonsoft.Json.JsonProperty("thursday", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Thursday { get; set; }

        /// <summary>When true, the value applies on this day</summary>
        [Newtonsoft.Json.JsonProperty("friday", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Friday { get; set; }

        /// <summary>When true, the value applies on this day</summary>
        [Newtonsoft.Json.JsonProperty("saturday", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Saturday { get; set; }

        /// <summary>When true, the value applies on this day</summary>
        [Newtonsoft.Json.JsonProperty("sunday", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Sunday { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The deposit details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Deposit
    {
        /// <summary>The requested deposit code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>The requested deposit description</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }
    
        /// <summary>The requested deposit amount</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; }
    
        /// <summary>The deadline for the deposit payment</summary>
        [Newtonsoft.Json.JsonProperty("dueDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? DueDate { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The calculation definition in case this rate plan is derived from another rate plan</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class DerivedRate
    {
        /// <summary>Identifies the rate plan code used as the base for the calculation</summary>
        [Newtonsoft.Json.JsonProperty("baseRatePlanCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BaseRatePlanCode { get; set; }

        /// <summary>Identifies the rate plan category used as the base for the calculation</summary>
        [Newtonsoft.Json.JsonProperty("baseRatePlanCategoryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BaseRatePlanCategoryCode { get; set; }

        /// <summary>The percent value to increase / decrease the rate plan</summary>
        [Newtonsoft.Json.JsonProperty("adjustedPercent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AdjustedPercent { get; set; }

        /// <summary>The absolute value to increase / decrease the rate plan</summary>
        [Newtonsoft.Json.JsonProperty("adjustedAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AdjustedAmount { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The discount associated with the price</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Discount
    {
        /// <summary>The start date for which the discount applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for which the discount applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>The identifier for the discount</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>The percent value associated with the discount</summary>
        [Newtonsoft.Json.JsonProperty("percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Percent { get; set; }

        /// <summary>The amount per night for the discount excluding all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountBeforeTax { get; set; }

        /// <summary>The amount per night for the discount including all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountAfterTax { get; set; }

        /// <summary>The amount allocated to the revenue code</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>When true, indicates that the discount amount is included in the price amount</summary>
        [Newtonsoft.Json.JsonProperty("isIncluded", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsIncluded { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Personal documents</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Document
    {
        /// <summary>The document type such as Passport, ID, Driver License</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Type { get; set; }

        /// <summary>The ID for the document</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The masked ID for the document</summary>
        [Newtonsoft.Json.JsonProperty("maskedId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaskedId { get; set; }

        /// <summary>The entity name that issued the document</summary>
        [Newtonsoft.Json.JsonProperty("issuedBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IssuedBy { get; set; }

        /// <summary>The issue date for the document. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("issueDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? IssueDate { get; set; }

        /// <summary>The issue date for the document. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("expireDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? ExpireDate { get; set; }

        /// <summary>When true, indicates this is the primary document for the guest</summary>
        [Newtonsoft.Json.JsonProperty("isPrimary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsPrimary { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The entity details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EntityDetails 
    {
        /// <summary>A collection of external IDs to identify the record on other systems</summary>
        [Newtonsoft.Json.JsonProperty("referenceIds", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<ReferenceId> ReferenceIds { get; set; } = new System.Collections.ObjectModel.Collection<ReferenceId>();
    
        /// <summary>The name for the entity</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>The type for the entity</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The extra bed details associated with the unit</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ExtraBed
    {
        /// <summary>The type for the extra bed associated with the unit</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>The quantity of beds of the informed type per unit</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Count { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class FinancialTransaction
    {
        [Newtonsoft.Json.JsonProperty("propertyDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public PropertyDetails PropertyDetails { get; set; }

        /// <summary>A collection of IDs to identify the record in other systems</summary>
        [Newtonsoft.Json.JsonProperty("referenceIds", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<ReferenceId> ReferenceIds { get; set; } = new System.Collections.ObjectModel.Collection<ReferenceId>();

        /// <summary>The date and time the transaction was created. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>The date and time the transaction was last modified, if transaction has not been modified use date created. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>A custom code specifying the type of transaction</summary>
        [Newtonsoft.Json.JsonProperty("transactionCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionCode { get; set; }

        /// <summary>The business date of the transaction. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("businessDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? BusinessDate { get; set; }

        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Currency Currency { get; set; }

        /// <summary>The number of items related to the amount of the transaction</summary>
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Quantity { get; set; }

        /// <summary>Identifies the type of notification</summary>
        [Newtonsoft.Json.JsonProperty("notificationType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FinancialTransactionNotificationType? NotificationType { get; set; }

        /// <summary>The Hapi unique id for the transaction</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The user or system who created the transaction</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The user or system who last modified the transaction</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }

        /// <summary>Specifies the group for which the transaction applies</summary>
        [Newtonsoft.Json.JsonProperty("transactionCodeGroup", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionCodeGroup { get; set; }

        /// <summary>The revenue code associated with the amount</summary>
        [Newtonsoft.Json.JsonProperty("transactionRevenueType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionRevenueType { get; set; }

        /// <summary>The type for the transaction. Available values: PAYMENT, DEPOSIT, POSTING, TAX, PAID_OUT, NON_REVENUE, ACCOUNT_RECEIVABLE, UNKNOWN</summary>
        [Newtonsoft.Json.JsonProperty("transactionType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FinancialTransactionTransactionType? TransactionType { get; set; }

        /// <summary>The name for the transaction</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>A description of the transaction</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>The amount associated with the transaction</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>The amount excluding all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountBeforeTax { get; set; }

        /// <summary>The amount including all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountAfterTax { get; set; }

        /// <summary>Describes the reason for adjustment</summary>
        [Newtonsoft.Json.JsonProperty("adjustmentReason", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdjustmentReason { get; set; }

        /// <summary>Invoice number to which the transaction belongs</summary>
        [Newtonsoft.Json.JsonProperty("invoiceNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InvoiceNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("paymentMethod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>A collection of POS details for the transaction</summary>
        [Newtonsoft.Json.JsonProperty("posTransactionDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PosTransactionDetails> PosTransactionDetails { get; set; }

        /// <summary>A collection of taxes associated with the transaction</summary>
        [Newtonsoft.Json.JsonProperty("taxes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tax> Taxes { get; set; }

        /// <summary>A collection of segmentations associated with the transaction</summary>
        [Newtonsoft.Json.JsonProperty("segmentations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Segmentation> Segmentations { get; set; }
    
        /// <summary>A collection of additional references associated with the transaction</summary>
        [Newtonsoft.Json.JsonProperty("additionalReferences", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<ReferenceId> AdditionalReferences { get; set; } = new System.Collections.ObjectModel.Collection<ReferenceId>();

        /// <summary>A collection of additional data associated with the transaction</summary>
        [Newtonsoft.Json.JsonProperty("additionalData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalData> AdditionalData { get; set; }

        // do not use - only for v2 to v3 backwards compatibility
        //[Newtonsoft.Json.JsonProperty("reservationDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //public ReservationDetails ReservationDetails { get; set; }

        /// <summary>When true, this transaction is an adjustment</summary>
        [Newtonsoft.Json.JsonProperty("isAdjustment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAdjustment { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        public EnvelopeOfFinancialTransaction ToEnvelope()
        {
            return new EnvelopeOfFinancialTransaction()
            {
                Data = this,
                ReceivedDateTime = System.DateTime.UtcNow,
                CreatedDateTime = System.DateTime.UtcNow,
                LastModifiedDateTime = System.DateTime.UtcNow
            };
        }
    }

    /// <summary>The fixed charge details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class FixedCharge
    {
        /// <summary>The start date for which the fixed charge applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Start { get; set; }

        /// <summary>The end date for which the fixed charge applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? End { get; set; }

        /// <summary>The identifier for the fixed charge, generally the transaction code associated with the charge</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>Defines on which frequency the fixed charge applies and will be posted</summary>
        [Newtonsoft.Json.JsonProperty("postingFrequency", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FixedChargePostingFrequency PostingFrequency { get; set; }

        /// <summary>Defines when the fixed charge should be posted and is required for weekly frequency</summary>
        [Newtonsoft.Json.JsonProperty("postingDayOfWeek", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FixedChargePostingDayOfWeek? PostingDayOfWeek { get; set; }

        /// <summary>Defines when the fixed charge should be posted and is required for monthly, quarterly and yearly frequencies. Available value are [1..31] and END</summary>
        [Newtonsoft.Json.JsonProperty("postingDayOfMonth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostingDayOfMonth { get; set; }

        /// <summary>Defines when the fixed charge should be posted and is required for yearly frequency. Formatted using ISO 8601 (MM-DD)</summary>
        [Newtonsoft.Json.JsonProperty("postingDayOfYear", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostingDayOfYear { get; set; }

        /// <summary>The quantity for the fixed charge</summary>
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Quantity { get; set; }

        /// <summary>The fixed charge amount per unit in correlation with the frequency</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>The fixed charge amount per unit excluding all associated taxes in correlation with the frequency</summary>
        [Newtonsoft.Json.JsonProperty("amountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountBeforeTax { get; set; }

        /// <summary>The fixed charge amount per unit including all associated taxes in correlation with the frequency</summary>
        [Newtonsoft.Json.JsonProperty("amountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountAfterTax { get; set; }

        /// <summary>The description for the fixed charge</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>When true, the fixed charge amount is included in the rate amount</summary>
        [Newtonsoft.Json.JsonProperty("isIncluded", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsIncluded { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ForecastRevenue
    {
        /// <summary>The start date for which the values in the array apply. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for which the values in the array apply. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>A collection of revenue details per revenue type for the defined date range</summary>
        [Newtonsoft.Json.JsonProperty("revenueDetails", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<RevenueDetails> RevenueDetails { get; set; } = new System.Collections.ObjectModel.Collection<RevenueDetails>();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Global Identifier</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class GlobalIdentifier
    {
        /// <summary>The ID type such as IATA, DUNS, GIATA</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; }

        /// <summary>The ID associated with the type</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The guest details, generally associated with a reservation</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Guest
    {
        /// <summary>The Hapi unique ID for the guest profile</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The type for the profile</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GuestType Type { get; set; }

        [Newtonsoft.Json.JsonProperty("propertyDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public PropertyDetails PropertyDetails { get; set; } = new PropertyDetails();

        /// <summary>Identifies the type of notification</summary>
        [Newtonsoft.Json.JsonProperty("notificationType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GuestNotificationType? NotificationType { get; set; }

        /// <summary>A collection of IDs to identify the record on other systems</summary>
        [Newtonsoft.Json.JsonProperty("referenceIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<ReferenceId> ReferenceIds { get; set; } = new System.Collections.ObjectModel.Collection<ReferenceId>();

        /// <summary>The date and time the profile was created. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>The user or system who created the profile</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The date and time the profile was last modified, if the profile has not been modified use date created. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>The user or system who last modified the profile</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string LastModifiedBy { get; set; }

        /// <summary>The status for the profile</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GuestStatus? Status { get; set; }

        /// <summary>Since when the profile is inactive. Required when the "status" is "INACTIVE"</summary>
        [Newtonsoft.Json.JsonProperty("inactiveDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? InactiveDate { get; set; }

        /// <summary>The guest name details</summary>
        [Newtonsoft.Json.JsonProperty("names", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<PersonName> Names { get; set; } = new System.Collections.ObjectModel.Collection<PersonName>();

        [Newtonsoft.Json.JsonProperty("primaryLanguage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Language PrimaryLanguage { get; set; }

        /// <summary>The guest gender</summary>
        [Newtonsoft.Json.JsonProperty("gender", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GuestGender? Gender { get; set; }

        /// <summary>The date of birth for the guest. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("dateOfBirth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? DateOfBirth { get; set; }

        /// <summary>The place of birth of the guest as specified in documents</summary>
        [Newtonsoft.Json.JsonProperty("placeOfBirth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlaceOfBirth { get; set; }

        [Newtonsoft.Json.JsonProperty("nationality", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Country Nationality { get; set; }

        /// <summary>A collection of addresses for the guest</summary>
        [Newtonsoft.Json.JsonProperty("addresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Address> Addresses { get; set; }

        /// <summary>A collection of contact details</summary>
        [Newtonsoft.Json.JsonProperty("contactDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContactDetails> ContactDetails { get; set; }

        /// <summary>A collection of personal documents</summary>
        [Newtonsoft.Json.JsonProperty("documents", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Document> Documents { get; set; }

        [Newtonsoft.Json.JsonProperty("corporateDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CorporateDetails CorporateDetails { get; set; }

        /// <summary>A collection of preferences associated with the guest</summary>
        [Newtonsoft.Json.JsonProperty("preferences", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Preference> Preferences { get; set; }

        /// <summary>A collection of consents for the guest</summary>
        [Newtonsoft.Json.JsonProperty("consents", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Consent> Consents { get; set; }

        /// <summary>A collection of classification for the guest such as VIP level</summary>
        [Newtonsoft.Json.JsonProperty("classifications", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Classification> Classifications { get; set; }

        /// <summary>A collection of memberships associated with the guest</summary>
        [Newtonsoft.Json.JsonProperty("memberships", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Membership> Memberships { get; set; }

        /// <summary>A collection of comments associated with the guest</summary>
        [Newtonsoft.Json.JsonProperty("comments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Comment> Comments { get; set; }

        /// <summary>Information associated with guest</summary>
        [Newtonsoft.Json.JsonProperty("additionalData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalData> AdditionalData { get; set; }

        /// <summary>A collection of relationships</summary>
        [Newtonsoft.Json.JsonProperty("relationships", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Relationship> Relationships { get; set; }
    
        /// <summary>A collection of sales attributes and segmentation associated with the guest</summary>
        [Newtonsoft.Json.JsonProperty("salesSegmentations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SalesSegmentation> SalesSegmentations { get; set; }
    
        /// <summary>When true, the guest wants to be anonymous while staying at the property</summary>
        [Newtonsoft.Json.JsonProperty("isPrivate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPrivate { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        public EnvelopeOfGuest ToEnvelope()
        {
            return new EnvelopeOfGuest()
            {
                Data = this,
                ReceivedDateTime = System.DateTime.UtcNow,
                CreatedDateTime = System.DateTime.UtcNow,
                LastModifiedDateTime = System.DateTime.UtcNow
            };
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Inventory
    {
        [Newtonsoft.Json.JsonProperty("propertyDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public PropertyDetails PropertyDetails { get; set; } = new PropertyDetails();

        /// <summary>A collection of inventory details</summary>
        [Newtonsoft.Json.JsonProperty("inventoryDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<InventoryDetails> InventoryDetails { get; set; } = new System.Collections.ObjectModel.Collection<InventoryDetails>();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        public EnvelopeOfInventory ToEnvelope()
        {
            return new EnvelopeOfInventory()
            {
                Data = this,
                ReceivedDateTime = System.DateTime.UtcNow,
                CreatedDateTime = System.DateTime.UtcNow,
                LastModifiedDateTime = System.DateTime.UtcNow
            };
        }
    }

    /// <summary>The inventory count associated with the unit type</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InventoryCount
    {
        /// <summary>Identifies the inventory type associated with the count</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InventoryCountType Type { get; set; }

        /// <summary>The number of units associated with the count type</summary>
        [Newtonsoft.Json.JsonProperty("unitCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UnitCount { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The inventory details by dates</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InventoryDetails
    {
        /// <summary>The start date for the inventory. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for the inventory. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        [Newtonsoft.Json.JsonProperty("unitType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public UnitType UnitType { get; set; } = new UnitType();

        /// <summary>A collection of inventory count associated with the unit types</summary>
        [Newtonsoft.Json.JsonProperty("inventoryCounts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<InventoryCount> InventoryCounts { get; set; } = new System.Collections.ObjectModel.Collection<InventoryCount>();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }

    /// <summary>The language identifier</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Language
    {
        /// <summary>The language code associated with the format</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>The format for the language</summary>
        [Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LanguageFormat? Format { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The membership details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Membership
    {
        /// <summary>The identifier for the membership</summary>
        [Newtonsoft.Json.JsonProperty("membershipCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MembershipCode { get; set; }

        /// <summary>The membership ID for the guest</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Id { get; set; }

        /// <summary>The guest name associated with the membership</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The level for the membership</summary>
        [Newtonsoft.Json.JsonProperty("level", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>The activation date for the membership. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("activationDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? ActivationDate { get; set; }

        /// <summary>The inactivation date for the membership. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("expirationDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>When true, indicates this is an active membership</summary>
        [Newtonsoft.Json.JsonProperty("isActive", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsActive { get; set; }

        /// <summary>When true, indicates this is the primary loyalty program to be used for the guest</summary>
        [Newtonsoft.Json.JsonProperty("isPrimary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPrimary { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The occupancy details per stay dates</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class OccupancyDetails
    {
        /// <summary>The start date for which the occupancy details apply. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for which the occupancy details apply. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>The occupant details per occupant type</summary>
        [Newtonsoft.Json.JsonProperty("occupants", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Occupants> Occupants { get; set; } = new System.Collections.ObjectModel.Collection<Occupants>();

        /// <summary>The children details per age</summary>
        [Newtonsoft.Json.JsonProperty("childrenDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ChildrenDetails> ChildrenDetails { get; set; }
    
        /// <summary>When true, the count of occupancy details are per reserved units</summary>
        [Newtonsoft.Json.JsonProperty("isPerUnit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsPerUnit { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Occupants
    {
        /// <summary>Specifies the type of occupant</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OccupantsType Type { get; set; }

        /// <summary>Number of occupant for the occupant type</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Count { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The reserved spaces for the date ranges, such as room, bed, apartment, etc.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class OccupiedReservationUnitDetails
    {
        /// <summary>The start date for which the values in the array apply. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for which the values in the array apply. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>Number of occupied physical unit. e.g: the occupied unit count will be higher in case of connected rooms that are reserved as a suite</summary>
        [Newtonsoft.Json.JsonProperty("physicalUnitCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PhysicalUnitCount { get; set; }

        /// <summary>Identifies the unit class</summary>
        [Newtonsoft.Json.JsonProperty("unitClassCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitClassCode { get; set; }

        /// <summary>The name for the unit class as room, bed or apartment</summary>
        [Newtonsoft.Json.JsonProperty("unitClassName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitClassName { get; set; }

        /// <summary>Identifies the category associated with the unit type</summary>
        [Newtonsoft.Json.JsonProperty("unitCategoryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitCategoryCode { get; set; }

        /// <summary>The unit category name</summary>
        [Newtonsoft.Json.JsonProperty("unitCategoryName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitCategoryName { get; set; }

        /// <summary>Identifies unit type code</summary>
        [Newtonsoft.Json.JsonProperty("unitTypeCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string UnitTypeCode { get; set; }

        /// <summary>The unit type name</summary>
        [Newtonsoft.Json.JsonProperty("unitTypeName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitTypeName { get; set; }

        /// <summary>The allocated unit's identifier</summary>
        [Newtonsoft.Json.JsonProperty("unitId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitId { get; set; }

        /// <summary>A collection of extra beds associated with the unit</summary>
        [Newtonsoft.Json.JsonProperty("extraBeds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ExtraBed> ExtraBeds { get; set; }

        /// <summary>When true, the unit is to be considered in forecast statistics</summary>
        [Newtonsoft.Json.JsonProperty("isForecasted", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsForecasted { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The payment method details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PaymentMethod
    {
        /// <summary>Identifies the method</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The guest name details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class PersonName
    {
        /// <summary>The type for the guest name</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PersonNameType? Type { get; set; }

        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Language Language { get; set; }

        /// <summary>The salutation for the person (e.g. Mr., Mrs.)</summary>
        [Newtonsoft.Json.JsonProperty("salutation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Salutation { get; set; }

        /// <summary>The given name, first name or names</summary>
        [Newtonsoft.Json.JsonProperty("givenName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GivenName { get; set; }

        /// <summary>The middle name of the person name</summary>
        [Newtonsoft.Json.JsonProperty("middleName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        /// <summary>The family name, last name. May also be used for full name of the sending system does not have the ability to separate a full name into parts</summary>
        [Newtonsoft.Json.JsonProperty("surname", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Surname { get; set; }

        /// <summary>The degree of honor (e.g. Ph.D, M.D.)</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>The name suffix (e.g. Jr., Sr., III)</summary>
        [Newtonsoft.Json.JsonProperty("suffix", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Suffix { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The POS details for the transaction</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PosTransactionDetails
    {
        /// <summary>An identifier of the POS system or outlet</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>An identifier of the POS check that the transaction belongs to</summary>
        [Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        /// <summary>An identifier for the POS transaction</summary>
        [Newtonsoft.Json.JsonProperty("checkId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckId { get; set; }

        /// <summary>The number of covers assigned to the check that the transaction belongs to</summary>
        [Newtonsoft.Json.JsonProperty("covers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Covers { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The preference details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Preference
    {
        /// <summary>The identifier for the preference</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>The type for the preference</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>The name for the preference</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The description for the preference</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>The identifier for the property where the preference applies. Informed when isGlobal is false</summary>
        [Newtonsoft.Json.JsonProperty("propertyCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PropertyCode { get; set; }

        /// <summary>When true, the preference applies to all properties</summary>
        [Newtonsoft.Json.JsonProperty("isGlobal", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsGlobal { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The price details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Price
    {
        /// <summary>The start date that the rate applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date that the rate applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>The rate plan code associated with the prices</summary>
        [Newtonsoft.Json.JsonProperty("ratePlanCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RatePlanCode { get; set; }

        /// <summary>The rate amount per night excluding all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountBeforeTax { get; set; }

        /// <summary>The rate amount per night including all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountAfterTax { get; set; }

        /// <summary>The amount allocated to the revenue code</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The non guest profile details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Profile
    {
        /// <summary>The Hapi unique id for the guest profile</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The type for the profile</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProfileType? Type { get; set; }

        [Newtonsoft.Json.JsonProperty("propertyDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public PropertyDetails PropertyDetails { get; set; } = new PropertyDetails();

        /// <summary>A collection of IDs to identify the record on other systems</summary>
        [Newtonsoft.Json.JsonProperty("referenceIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReferenceId> ReferenceIds { get; set; }

        /// <summary>The date and time the profile was created. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>The user or system who created the profile</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The date and time the profile was last modified, if the profile has not been modified use created date. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>The user or system who last modified the profile</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }

        /// <summary>A collection of names for the profile</summary>
        [Newtonsoft.Json.JsonProperty("names", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ProfileName> Names { get; set; }

        /// <summary>Identifies the type of notification</summary>
        [Newtonsoft.Json.JsonProperty("notificationType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProfileNotificationType? NotificationType { get; set; }

        /// <summary>The status for the profile</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProfileStatus? Status { get; set; }

        /// <summary>Since when the profile is inactive. Required when the "status" is "INACTIVE". Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("inactiveDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? InactiveDate { get; set; }

        /// <summary>The website associated with the profile</summary>
        [Newtonsoft.Json.JsonProperty("website", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Website { get; set; }

        /// <summary>A collection of global identifiers</summary>
        [Newtonsoft.Json.JsonProperty("globalIdentifiers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<GlobalIdentifier> GlobalIdentifiers { get; set; }

        /// <summary>A collection of addresses for the profile</summary>
        [Newtonsoft.Json.JsonProperty("addresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Address> Addresses { get; set; }

        [Newtonsoft.Json.JsonProperty("accountingDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AccountingDetails AccountingDetails { get; set; }

        /// <summary>A collection of contact details for the profile</summary>
        [Newtonsoft.Json.JsonProperty("contactDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContactDetails> ContactDetails { get; set; }

        /// <summary>A collection of contacts associated with the profile</summary>
        [Newtonsoft.Json.JsonProperty("contactPersons", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContactPerson> ContactPersons { get; set; }

        /// <summary>A collection of comments associated with the profile</summary>
        [Newtonsoft.Json.JsonProperty("comments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Comment> Comments { get; set; }

        /// <summary>Information associated with profile</summary>
        [Newtonsoft.Json.JsonProperty("additionalData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalData> AdditionalData { get; set; }

        /// <summary>A collection of relationships</summary>
        [Newtonsoft.Json.JsonProperty("relationships", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Relationship> Relationships { get; set; }
    
        /// <summary>A collection of sales attributes and segmentation associated with the profile</summary>
        [Newtonsoft.Json.JsonProperty("salesSegmentations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SalesSegmentation> SalesSegmentations { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

       
        public EnvelopeOfProfile ToEnvelope()
        {
            return new EnvelopeOfProfile()
            {
                Data = this,
                ReceivedDateTime = System.DateTime.UtcNow,
                CreatedDateTime = System.DateTime.UtcNow,
                LastModifiedDateTime = System.DateTime.UtcNow
            };
        }
    }

    /// <summary>The name details associated with the profile</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ProfileName
    {
        /// <summary>The profile name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Name { get; set; }

        /// <summary>The type associated with the name</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProfileNameType? Type { get; set; }

        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Language Language { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The property identifiers for the message</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class PropertyDetails
    {
        /// <summary>The Hapi property code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>The Hapi chain code</summary>
        [Newtonsoft.Json.JsonProperty("chainCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string ChainCode { get; set; }

        /// <summary>The Hapi brand code</summary>
        [Newtonsoft.Json.JsonProperty("brandCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BrandCode { get; set; }

        public void AddChainCode(string chainCode)
        {
            ChainCode = chainCode;
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Rate
    {
        [Newtonsoft.Json.JsonProperty("propertyDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public PropertyDetails PropertyDetails { get; set; } = new PropertyDetails();

        /// <summary>The Hapi unique id for the rate</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        /// <summary>The rate plan code or short name</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Code { get; set; }
    
        /// <summary>A collection of IDs to identify the record on other systems</summary>
        [Newtonsoft.Json.JsonProperty("referenceIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReferenceId> ReferenceIds { get; set; }

        /// <summary>The start date for which the values in the array apply. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Start { get; set; }

        /// <summary>The end date for which the values in the array apply. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? End { get; set; }

        /// <summary>Identifies the type of notification</summary>
        [Newtonsoft.Json.JsonProperty("notificationType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RateNotificationType? NotificationType { get; set; }

        /// <summary>The status for the rate</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RateStatus? Status { get; set; }

        /// <summary>The date and time the rate was created. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>The user or system who created the rate</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The date and time the rate was last modified, if rate has not been modified use created date. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>The user or system who last modified the rate</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }

        /// <summary>The rate plan name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The category code associated with the rate plan</summary>
        [Newtonsoft.Json.JsonProperty("categoryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryCode { get; set; }

        /// <summary>The category name associated with the rate plan</summary>
        [Newtonsoft.Json.JsonProperty("categoryName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>The type for the rate plan such as public, negotiated, etc.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>The short description for the rate plan</summary>
        [Newtonsoft.Json.JsonProperty("shortDescription", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShortDescription { get; set; }

        /// <summary>The long description for the rate plan</summary>
        [Newtonsoft.Json.JsonProperty("longDescription", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LongDescription { get; set; }

        [Newtonsoft.Json.JsonProperty("daysOfWeek", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DaysOfWeek DaysOfWeek { get; set; }

        /// <summary>The booking rules associated with the rate plan</summary>
        [Newtonsoft.Json.JsonProperty("bookingRules", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BookingRule> BookingRules { get; set; }

        /// <summary>The cancellation policy details that apply to the rate plan</summary>
        [Newtonsoft.Json.JsonProperty("cancellationRules", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CancellationPolicy> CancellationRules { get; set; }

        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Currency Currency { get; set; }

        [Newtonsoft.Json.JsonProperty("derivedRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DerivedRate DerivedRate { get; set; }

        /// <summary>A collection of segmentations associated with the rate</summary>
        [Newtonsoft.Json.JsonProperty("segmentations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Segmentation> Segmentations { get; set; }

        /// <summary>A collection of pricing details</summary>
        [Newtonsoft.Json.JsonProperty("pricings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RatePricing> Pricings { get; set; }

        /// <summary>A collection of additional data</summary>
        [Newtonsoft.Json.JsonProperty("additionalData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalData> AdditionalData { get; set; }

        /// <summary>A collection of services associated with the rate</summary>
        [Newtonsoft.Json.JsonProperty("services", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RateService> Services { get; set; }

        /// <summary>When true, indicates this a negotiated rate</summary>
        [Newtonsoft.Json.JsonProperty("isNegotiated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsNegotiated { get; set; }

        /// <summary>When true, indicates this is a House Use rate</summary>
        [Newtonsoft.Json.JsonProperty("isHouseUse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsHouseUse { get; set; }

        /// <summary>When true, indicates this is a non refundable rate</summary>
        [Newtonsoft.Json.JsonProperty("isNonRefundable", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsNonRefundable { get; set; }

        /// <summary>When true, indicates this is a complimentary rate</summary>
        [Newtonsoft.Json.JsonProperty("isComplimentary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsComplimentary { get; set; }

        /// <summary>When true, indicates this is a commissionable rate</summary>
        [Newtonsoft.Json.JsonProperty("isCommissionable", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsCommissionable { get; set; }
    
        /// <summary>When true, indicates this is a confidential rate and the price should not be disclosed to the guest/customer</summary>
        [Newtonsoft.Json.JsonProperty("isConfidential", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsConfidential { get; set; }
    
        /// <summary>When true, indicates that prices are expressed after tax</summary>
        [Newtonsoft.Json.JsonProperty("isTaxInclusive", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsTaxInclusive { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        public EnvelopeOfRate ToEnvelope()
        {
            return new EnvelopeOfRate()
            {
                Data = this,
                ReceivedDateTime = System.DateTime.UtcNow,
                CreatedDateTime = System.DateTime.UtcNow,
                LastModifiedDateTime = System.DateTime.UtcNow
            };
        }
    }

    /// <summary>The rate plan details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RatePlan
    {
        /// <summary>The start date for which the rate plan applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Start { get; set; }

        /// <summary>The end date that the rate plan applies</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? End { get; set; }

        /// <summary>The rate plan code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>The rate plan name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The rate plan description</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>The rate plan category code</summary>
        [Newtonsoft.Json.JsonProperty("categoryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryCode { get; set; }

        /// <summary>The rate plan category name</summary>
        [Newtonsoft.Json.JsonProperty("categoryName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        [Newtonsoft.Json.JsonProperty("cancellationPolicy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CancellationPolicy CancellationPolicy { get; set; }

        /// <summary>When true, indicates this rate plan is confidential and the rate should not be shared with the guest</summary>
        [Newtonsoft.Json.JsonProperty("isConfidential", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsConfidential { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The price details of a rate</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RatePricing
    {
        /// <summary>A collection of unit types associated with the price</summary>
        [Newtonsoft.Json.JsonProperty("unitTypes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<UnitType> UnitTypes { get; set; } = new System.Collections.ObjectModel.Collection<UnitType>();

        /// <summary>The start date for the pricing details. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for the pricing details. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>The base price details</summary>
        [Newtonsoft.Json.JsonProperty("basePrices", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BasePrice> BasePrices { get; set; }

        /// <summary>The status for the pricing details</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RatePricingStatus? Status { get; set; }

        [Newtonsoft.Json.JsonProperty("daysOfWeek", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DaysOfWeek DaysOfWeek { get; set; }

        /// <summary>A collection of prices for additional occupants</summary>
        [Newtonsoft.Json.JsonProperty("additionalOccupantsPrices", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalOccupantsPrice> AdditionalOccupantsPrices { get; set; }

        /// <summary>A collection of prices for additional beds</summary>
        [Newtonsoft.Json.JsonProperty("additionalBedPrices", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalItemPrice> AdditionalBedPrices { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The rate service details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RateService
    {
        /// <summary>Identifies the service</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>The name or description for the service</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>IDs to identify the record on other systems</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ReferenceId
    {
        /// <summary>A string that uniquely identifies the system that uses the reference; for example, the specific OTA</summary>
        [Newtonsoft.Json.JsonProperty("systemId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemId { get; set; }

        /// <summary>A string that defines the system type associated with the id</summary>
        [Newtonsoft.Json.JsonProperty("systemType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemType { get; set; }

        /// <summary>The interface identifier associated with the systemId and/or customer</summary>
        [Newtonsoft.Json.JsonProperty("interfaceId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InterfaceId { get; set; }
        
        /// <summary>The type for the id</summary>
        [Newtonsoft.Json.JsonProperty("idType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReferenceIdIdType IdType { get; set; }

        /// <summary>The key that can be used to retrieve the related record in the source system</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; }

        /// <summary>Identifies the sequence when multiple records of this type share the same id</summary>
        [Newtonsoft.Json.JsonProperty("legNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LegNumber { get; set; }

        /// <summary>When true, the system is the source of sale</summary>
        [Newtonsoft.Json.JsonProperty("isSource", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsSource { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The relationship details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Relationship 
    {
        [Newtonsoft.Json.JsonProperty("relatesTo", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public EntityDetails RelatesTo { get; set; } = new EntityDetails();
    
        [Newtonsoft.Json.JsonProperty("relatesAs", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public RoleDetails RelatesAs { get; set; } = new RoleDetails();
    
        /// <summary>When true, this indicated this is a primary relationship </summary>
        [Newtonsoft.Json.JsonProperty("isPrimary", Required = Newtonsoft.Json.Required.Always)]
        public bool IsPrimary { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Reservation
    {
        [Newtonsoft.Json.JsonProperty("propertyDetails", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public PropertyDetails PropertyDetails { get; set; } = new PropertyDetails();

        /// <summary>Identifies the type of notification</summary>
        [Newtonsoft.Json.JsonProperty("notificationType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReservationNotificationType? NotificationType { get; set; }

        /// <summary>The Hapi unique id for the reservation</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>A collection of IDs to identify the record on other systems</summary>
        [Newtonsoft.Json.JsonProperty("referenceIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReferenceId> ReferenceIds { get; set; }

        /// <summary>The Status for the reservation</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReservationStatus? Status { get; set; }

        /// <summary>The date and time the reservation was created. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>The user or system who created the reservation</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The date and time the reservation was last modified, if reservation has not been modified use created date. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>The user or system who last modified the reservation</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }

        [Newtonsoft.Json.JsonProperty("cancellationDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CancellationDetails CancellationDetails { get; set; }

        /// <summary>The date and time that the reservation will be invalid if not confirmed. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("optionDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? OptionDate { get; set; }

        /// <summary>The arrival date for the reservation. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("arrival", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Arrival { get; set; }

        /// <summary>The estimated date and time of arrival. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("estimatedDateTimeOfArrival", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? EstimatedDateTimeOfArrival { get; set; }

        /// <summary>The actual date and time of arrival. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("actualDateTimeOfArrival", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? ActualDateTimeOfArrival { get; set; }

        /// <summary>The departure date for the reservation. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("departure", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Departure { get; set; }

        /// <summary>The estimated date and time of departure. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("estimatedDateTimeOfDeparture", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? EstimatedDateTimeOfDeparture { get; set; }

        /// <summary>The actual date and time of departure. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("actualDateTimeOfDeparture", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? ActualDateTimeOfDeparture { get; set; }

        /// <summary>A collection of booked units, generally associated with the rates</summary>
        [Newtonsoft.Json.JsonProperty("bookedUnits", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BookedReservationUnitDetails> BookedUnits { get; set; }

        /// <summary>A collection of occupied units</summary>
        [Newtonsoft.Json.JsonProperty("occupiedUnits", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<OccupiedReservationUnitDetails> OccupiedUnits { get; set; }

        /// <summary>The occupancy details per stay dates</summary>
        [Newtonsoft.Json.JsonProperty("occupancyDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<OccupancyDetails> OccupancyDetails { get; set; }

        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Currency Currency { get; set; }

        [Newtonsoft.Json.JsonProperty("reservationTotal", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ReservationTotal ReservationTotal { get; set; }

        /// <summary>A collection of taxes</summary>
        [Newtonsoft.Json.JsonProperty("taxes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tax> Taxes { get; set; }

        /// <summary>A collection of rate plans associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("ratePlans", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RatePlan> RatePlans { get; set; }

        /// <summary>The price details associated with the rate plan</summary>
        [Newtonsoft.Json.JsonProperty("prices", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Price> Prices { get; set; }

        /// <summary>A collection of discounts</summary>
        [Newtonsoft.Json.JsonProperty("discounts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Discount> Discounts { get; set; }

        /// <summary>The promotion code associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("promotionCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PromotionCode { get; set; }

        /// <summary>A collection of cancellation policies associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("cancellationPolicies", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CancellationPolicy> CancellationPolicies { get; set; }

        /// <summary>A collection of services associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("services", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Service> Services { get; set; }

        /// <summary>A collection of fixed charges associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("fixedCharges", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FixedCharge> FixedCharges { get; set; }

        /// <summary>The forecast revenue associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("forecastRevenue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ForecastRevenue> ForecastRevenue { get; set; }

        /// <summary>A collection of block IDs associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("blocks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CrossReference> Blocks { get; set; }

        /// <summary>A collection of requested deposits</summary>
        [Newtonsoft.Json.JsonProperty("requestedDeposits", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Deposit> RequestedDeposits { get; set; }

        /// <summary>Identifies how the reservation is guaranteed</summary>
        [Newtonsoft.Json.JsonProperty("guaranteeCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GuaranteeCode { get; set; }

        [Newtonsoft.Json.JsonProperty("paymentMethod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>A collection of sharer IDs</summary>
        [Newtonsoft.Json.JsonProperty("sharerIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReferenceId> SharerIds { get; set; }

        /// <summary>A collection of reservations allocated to the same unitId</summary>
        [Newtonsoft.Json.JsonProperty("shareDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ShareDetails> ShareDetails { get; set; }

        /// <summary>A collection of segmentations for the reservation</summary>
        [Newtonsoft.Json.JsonProperty("segmentations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Segmentation> Segmentations { get; set; }

        /// <summary>A collection of special requests that apply to the reservation</summary>
        [Newtonsoft.Json.JsonProperty("specialRequests", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SpecialRequest> SpecialRequests { get; set; }

        /// <summary>A collection of commissions associated to the reservation</summary>
        [Newtonsoft.Json.JsonProperty("commissions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Commission> Commissions { get; set; }

        /// <summary>A collection of comments associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("comments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Comment> Comments { get; set; }

        /// <summary>A collection of alerts associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("alerts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Alert> Alerts { get; set; }

        /// <summary>A collection of memberships that apply to the reservation</summary>
        [Newtonsoft.Json.JsonProperty("memberships", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Membership> Memberships { get; set; }

        /// <summary>A collection of transportation details for the guest</summary>
        [Newtonsoft.Json.JsonProperty("transfers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Transfer> Transfers { get; set; }

        /// <summary>A collection of non guest profiles associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("profiles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Profile> Profiles { get; set; }

        /// <summary>A collection of additional data for the reservation</summary>
        [Newtonsoft.Json.JsonProperty("additionalData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalData> AdditionalData { get; set; }

        /// <summary>A collection of guests associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("guests", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReservationGuest> Guests { get; set; }

        /// <summary>A collection of contact profiles associated with the reservation</summary>
        [Newtonsoft.Json.JsonProperty("contacts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Guest> Contacts { get; set; }
    
        /// <summary>The purpose of the stay such as leisure, business, conference, etc.</summary>
        [Newtonsoft.Json.JsonProperty("purposeOfStay", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PurposeOfStay { get; set; }
    
        /// <summary>When true, prices should not be displayed to the guest</summary>
        [Newtonsoft.Json.JsonProperty("doNotDisplayPrice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool DoNotDisplayPrice { get; set; }
    
        /// <summary>When true, the reservation is for house use</summary>
        [Newtonsoft.Json.JsonProperty("isHouseUse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsHouseUse { get; set; }

        /// <summary>When true, the reservation is complimentary</summary>
        [Newtonsoft.Json.JsonProperty("isComplimentary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsComplimentary { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        public EnvelopeOfReservation ToEnvelope()
        {
            return new EnvelopeOfReservation()
            {
                Data = this,
                ReceivedDateTime = System.DateTime.UtcNow,
                CreatedDateTime = System.DateTime.UtcNow,
                LastModifiedDateTime = System.DateTime.UtcNow
            };
        }
    }

    /// <summary>The reservation details associated with the object</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ReservationDetails
    {
        /// <summary>The occupied unit ID</summary>
        [Newtonsoft.Json.JsonProperty("unitId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitId { get; set; }

        [Newtonsoft.Json.JsonProperty("unitType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitType { get; set; }

        /// <summary>The rate plan code associated with the object</summary>
        [Newtonsoft.Json.JsonProperty("ratePlanCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RatePlanCode { get; set; }

        /// <summary>A collection of rates and prices associated with the stay</summary>
        [Newtonsoft.Json.JsonProperty("prices", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<StayPrice> Prices { get; set; }

        /// <summary>A collection of segmentations associated with the transaction</summary>
        [Newtonsoft.Json.JsonProperty("segmentations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Segmentation> Segmentations { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>The guest details associated with the reservation</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ReservationGuest
    {
        [Newtonsoft.Json.JsonProperty("guest", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public Guest Guest { get; set; } = new Guest();

        /// <summary>When true, indicates this is the primary guest for the reservation</summary>
        [Newtonsoft.Json.JsonProperty("isPrimary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsPrimary { get; set; } = true;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        
    }

    /// <summary>The total amount for the reservation including all services and additional charges</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ReservationTotal
    {
        /// <summary>The total amount for the reservation excluding all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountBeforeTax { get; set; }

        /// <summary>The total amount for the reservation including all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountAfterTax { get; set; }

        /// <summary>The amount allocated to the revenue code</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The revenue details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RevenueDetails
    {
        /// <summary>The revenue type associated with the amount</summary>
        [Newtonsoft.Json.JsonProperty("revenueType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RevenueType { get; set; }

        /// <summary>The revenue group associated with revenue transaction code</summary>
        [Newtonsoft.Json.JsonProperty("revenueTransactionGroupCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RevenueTransactionGroupCode { get; set; }

        /// <summary>The revenue code associated with the amount</summary>
        [Newtonsoft.Json.JsonProperty("revenueTransactionCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RevenueTransactionCode { get; set; }

        /// <summary>The amount allocated to the revenue code excluding all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountBeforeTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountBeforeTax { get; set; }

        /// <summary>The amount allocated to the revenue code including all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountAfterTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountAfterTax { get; set; }

        /// <summary>The amount allocated to the revenue code</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The role details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RoleDetails 
    {
        /// <summary>Identifies the role</summary>
        [Newtonsoft.Json.JsonProperty("roleCode", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string RoleCode { get; set; }
    
        /// <summary>Identifies the description</summary>
        [Newtonsoft.Json.JsonProperty("roleDescription", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string RoleDescription { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The sale segmentation details associated with the record</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SalesSegmentation 
    {
        /// <summary>The category associated with the type</summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; }
    
        /// <summary>The type associated with the code</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }
    
        /// <summary>The code associated with the value</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Code { get; set; }
    
        /// <summary>The value associated with the code</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Value { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The segmentation details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Segmentation
    {
        /// <summary>The start date for which the segment applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Start { get; set; }

        /// <summary>The end date for which the segment applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? End { get; set; }
  
        /// <summary>The type for the segmentation</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SegmentationType Type { get; set; }

        /// <summary>The segmentation code associated with the type</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Code { get; set; }

        /// <summary>The segment name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The category code for the segment</summary>
        [Newtonsoft.Json.JsonProperty("categoryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryCode { get; set; }

        /// <summary>The category name for the segment</summary>
        [Newtonsoft.Json.JsonProperty("categoryName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The service definition</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Service
    {
        /// <summary>The identifier for the service</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>The service name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The rate plan code associated with the service</summary>
        [Newtonsoft.Json.JsonProperty("ratePlanCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RatePlanCode { get; set; }

        /// <summary>The quantity for the service</summary>
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Quantity { get; set; }

        /// <summary>Defines on which frequency the services applies and will be posted</summary>
        [Newtonsoft.Json.JsonProperty("frequency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ServiceFrequency? Frequency { get; set; }

        /// <summary>The service total amount for the whole date range</summary>
        [Newtonsoft.Json.JsonProperty("totalAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? TotalAmount { get; set; }

        /// <summary>The service total amount excluding all associated taxes for the whole date range</summary>
        [Newtonsoft.Json.JsonProperty("totalAmountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? TotalAmountBeforeTax { get; set; }

        /// <summary>The service total amount including all associated taxes for the whole date range</summary>
        [Newtonsoft.Json.JsonProperty("totalAmountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? TotalAmountAfterTax { get; set; }

        /// <summary>A collection of service details</summary>
        [Newtonsoft.Json.JsonProperty("serviceDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ServiceDetails> ServiceDetails { get; set; }

        /// <summary>When true, the service amount is included in the rate amount</summary>
        [Newtonsoft.Json.JsonProperty("isIncluded", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsIncluded { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The service details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ServiceDetails
    {
        /// <summary>The start date for which the service applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for which the service applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>The service amount per unit</summary>
        [Newtonsoft.Json.JsonProperty("unitAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? UnitAmount { get; set; }

        /// <summary>The service amount per unit excluding all associated taxes in correlation with the frequency</summary>
        [Newtonsoft.Json.JsonProperty("unitAmountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? UnitAmountBeforeTax { get; set; }

        /// <summary>The service amount per unit including all associated taxes in correlation with the frequency</summary>
        [Newtonsoft.Json.JsonProperty("unitAmountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? UnitAmountAfterTax { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The sharer details, generally a reservation</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ShareDetails 
    {
        /// <summary>A collection of IDs to identify the record on other systems</summary>
        [Newtonsoft.Json.JsonProperty("referenceIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReferenceId> ReferenceIds { get; set; }

        /// <summary>A collection of sharer IDs</summary>
        [Newtonsoft.Json.JsonProperty("sharerIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReferenceId> SharerIds { get; set; }

        /// <summary>The arrival date for the reservation. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("arrival", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Arrival { get; set; }

        /// <summary>The departure date for the reservation. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("departure", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Departure { get; set; }

        [Newtonsoft.Json.JsonProperty("unitType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UnitType UnitType { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The special request details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SpecialRequest
    {
        /// <summary>The type for the special request</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>Identifies the special request</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>The special request name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The description for the special request</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The state or province identifiers</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class State
    {
        /// <summary>The state code. Formatted using ISO 3166</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>The state name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Stay
    {
        [Newtonsoft.Json.JsonProperty("propertyDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public PropertyDetails PropertyDetails { get; set; } = new PropertyDetails();

        /// <summary>Identifies the type of notification</summary>
        [Newtonsoft.Json.JsonProperty("notificationType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public StayNotificationType? NotificationType { get; set; }

        /// <summary>The Hapi unique id for the stay</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>A collection of IDs to identify the record on other systems</summary>
        [Newtonsoft.Json.JsonProperty("referenceIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReferenceId> ReferenceIds { get; set; }

        [Newtonsoft.Json.JsonProperty("reservation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CrossReference Reservation { get; set; }

        /// <summary>The date and time the stay was created. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>The user or system who created the stay</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The date and time the stay was last modified, if stay has not been modified use created date. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>The user or system who last modified the stay</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }

        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public Currency Currency { get; set; } = new Currency();

        /// <summary>The revenue summary for the stay</summary>
        [Newtonsoft.Json.JsonProperty("revenueSummary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RevenueDetails> RevenueSummary { get; set; }

        /// <summary>A collection of revenue details associated with the stay</summary>
        [Newtonsoft.Json.JsonProperty("revenueDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<StayRevenueDetails> RevenueDetails { get; set; }

        [Newtonsoft.Json.JsonProperty("reservationDetails", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ReservationDetails ReservationDetails { get; set; }

        /// <summary>Place holder for additional data associated with the stay</summary>
        [Newtonsoft.Json.JsonProperty("additionalData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalData> AdditionalData { get; set; }

        /// <summary>A collection of IDs for the guests associated with the stay</summary>
        [Newtonsoft.Json.JsonProperty("guests", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CrossReference> Guests { get; set; }

        /// <summary>A collection of IDs for the profiles associated with the stay</summary>
        [Newtonsoft.Json.JsonProperty("profiles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CrossReference> Profiles { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        public EnvelopeOfStay ToEnvelope()
        {
            return new EnvelopeOfStay()
            {
                Data = this,
                ReceivedDateTime = System.DateTime.UtcNow,
                CreatedDateTime = System.DateTime.UtcNow,
                LastModifiedDateTime = System.DateTime.UtcNow
            };
        }
    }

    /// <summary>The price details associated with the block inventory</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class StayPrice
    {
        /// <summary>The start date for which the values in the array apply</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start { get; set; }

        /// <summary>The end date for which the values in the array apply</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime End { get; set; }

        /// <summary>The rate plan code</summary>
        [Newtonsoft.Json.JsonProperty("ratePlanCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RatePlanCode { get; set; }

        /// <summary>The rate plan code</summary>
        [Newtonsoft.Json.JsonProperty("unitTypeCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitTypeCode { get; set; }

        /// <summary>The amount allocated to the revenue code excluding all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountBeforeTax { get; set; }

        /// <summary>The amount allocated to the revenue code</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>The amount allocated to the revenue code including all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountAfterTax { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }

    /// <summary>The revenue details associated with the stay</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class StayRevenueDetails
    {
        /// <summary>The business date when the revenue applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("businessDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime BusinessDate { get; set; }

        /// <summary>The unique id for the transaction/revenue details</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The revenue type associated with the amount</summary>
        [Newtonsoft.Json.JsonProperty("revenueType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RevenueType { get; set; }

        /// <summary>The revenue group associated with revenue</summary>
        [Newtonsoft.Json.JsonProperty("revenueTransactionGroupCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RevenueTransactionGroupCode { get; set; }

        /// <summary>The revenue code associated with the amount</summary>
        [Newtonsoft.Json.JsonProperty("revenueTransactionCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RevenueTransactionCode { get; set; }

        /// <summary>The amount allocated to the revenue code excluding all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountBeforeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountBeforeTax { get; set; }

        /// <summary>The amount allocated to the revenue code</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>The amount allocated to the revenue code including all associated taxes</summary>
        [Newtonsoft.Json.JsonProperty("amountAfterTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? AmountAfterTax { get; set; }

        /// <summary>The revenue code name or description associated with the amount</summary>
        [Newtonsoft.Json.JsonProperty("revenueTransactionCodeDescription", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RevenueTransactionCodeDescription { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The tax details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Tax
    {
        /// <summary>Identifies the tax</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>The tax amount</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal Amount { get; set; }

        /// <summary>The start date for which the tax applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Start { get; set; }

        /// <summary>The end date for which the tax applies. Formatted using ISO 8601</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? End { get; set; }

        /// <summary>The type for the tax</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>The transfer details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Transfer
    {
        /// <summary>Identifies the transportation such as the flight number</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>Identifies the type of transportation such as flight, train</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>The location for the transportation such as airport, train station</summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>The date and time for the transportation.</summary>
        [Newtonsoft.Json.JsonProperty("dateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? DateTime { get; set; }

        /// <summary>When true, the transportation applies on arrival</summary>
        [Newtonsoft.Json.JsonProperty("isOnArrival", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsOnArrival { get; set; }

        /// <summary>When true, the transportation applies on departure</summary>
        [Newtonsoft.Json.JsonProperty("isOnDeparture", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsOnDeparture { get; set; }

        /// <summary>When true, a transfer is required from/to the location</summary>
        [Newtonsoft.Json.JsonProperty("isTransferRequired", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsTransferRequired { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    /// <summary>Unit type</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UnitType
    {
        /// <summary>Identifies the unit type</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Code { get; set; }

        /// <summary>The unit type name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The code for the unit category</summary>
        [Newtonsoft.Json.JsonProperty("categoryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryCode { get; set; }

        /// <summary>The name for the unit category</summary>
        [Newtonsoft.Json.JsonProperty("categoryName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>The code for the unit class</summary>
        [Newtonsoft.Json.JsonProperty("unitClassCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitClassCode { get; set; }

        /// <summary>The name for the unit class</summary>
        [Newtonsoft.Json.JsonProperty("unitClassName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitClassName { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    #region Envelopes
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EnvelopeOfAvailability
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Availability Data { get; set; } = new Availability();

        /// <summary>The point in time when Hapi firstly receives the message from an external system. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("receivedDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime ReceivedDateTime { get; set; }

        /// <summary>The point in time when Hapi firstly created the message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime CreatedDateTime { get; set; }

        /// <summary>The DateTime of last update of a given message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime LastModifiedDateTime { get; set; }

        /// <summary>The version of the data model that represents the data in the 'data' field.</summary>
        [Newtonsoft.Json.JsonProperty("schemaVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemaVersion { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EnvelopeOfBlock
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Block Data { get; set; } = new Block();

        /// <summary>The point in time when Hapi firstly receives the message from an external system. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("receivedDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime ReceivedDateTime { get; set; }

        /// <summary>The point in time when Hapi firstly created the message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime CreatedDateTime { get; set; }

        /// <summary>The DateTime of last update of a given message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime LastModifiedDateTime { get; set; }

        /// <summary>The version of the data model that represents the data in the 'data' field.</summary>
        [Newtonsoft.Json.JsonProperty("schemaVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemaVersion { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EnvelopeOfFinancialTransaction
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public FinancialTransaction Data { get; set; } = new FinancialTransaction();

        /// <summary>The point in time when Hapi firstly receives the message from an external system. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("receivedDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime ReceivedDateTime { get; set; }

        /// <summary>The point in time when Hapi firstly created the message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime CreatedDateTime { get; set; }

        /// <summary>The DateTime of last update of a given message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime LastModifiedDateTime { get; set; }

        /// <summary>The version of the data model that represents the data in the 'data' field.</summary>
        [Newtonsoft.Json.JsonProperty("schemaVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemaVersion { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EnvelopeOfGuest
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Guest Data { get; set; } = new Guest();

        /// <summary>The point in time when Hapi firstly receives the message from an external system. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("receivedDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime ReceivedDateTime { get; set; }

        /// <summary>The point in time when Hapi firstly created the message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime CreatedDateTime { get; set; }

        /// <summary>The DateTime of last update of a given message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime LastModifiedDateTime { get; set; }

        /// <summary>The version of the data model that represents the data in the 'data' field.</summary>
        [Newtonsoft.Json.JsonProperty("schemaVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemaVersion { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EnvelopeOfInventory
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Inventory Data { get; set; } = new Inventory();

        /// <summary>The point in time when Hapi firstly receives the message from an external system. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("receivedDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime ReceivedDateTime { get; set; }

        /// <summary>The point in time when Hapi firstly created the message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime CreatedDateTime { get; set; }

        /// <summary>The DateTime of last update of a given message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime LastModifiedDateTime { get; set; }

        /// <summary>The version of the data model that represents the data in the 'data' field.</summary>
        [Newtonsoft.Json.JsonProperty("schemaVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemaVersion { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EnvelopeOfProfile
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Profile Data { get; set; } = new Profile();

        /// <summary>The point in time when Hapi firstly receives the message from an external system. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("receivedDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime ReceivedDateTime { get; set; }

        /// <summary>The point in time when Hapi firstly created the message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime CreatedDateTime { get; set; }

        /// <summary>The DateTime of last update of a given message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime LastModifiedDateTime { get; set; }

        /// <summary>The version of the data model that represents the data in the 'data' field.</summary>
        [Newtonsoft.Json.JsonProperty("schemaVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemaVersion { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EnvelopeOfRate
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Rate Data { get; set; } = new Rate();

        /// <summary>The point in time when Hapi firstly receives the message from an external system. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("receivedDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime ReceivedDateTime { get; set; }

        /// <summary>The point in time when Hapi firstly created the message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime CreatedDateTime { get; set; }

        /// <summary>The DateTime of last update of a given message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime LastModifiedDateTime { get; set; }

        /// <summary>The version of the data model that represents the data in the 'data' field.</summary>
        [Newtonsoft.Json.JsonProperty("schemaVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemaVersion { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EnvelopeOfReservation
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Reservation Data { get; set; } = new Reservation();

        /// <summary>The point in time when Hapi firstly receives the message from an external system. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("receivedDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime ReceivedDateTime { get; set; }

        /// <summary>The point in time when Hapi firstly created the message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime CreatedDateTime { get; set; }

        /// <summary>The DateTime of last update of a given message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime LastModifiedDateTime { get; set; }

        /// <summary>The version of the data model that represents the data in the 'data' field.</summary>
        [Newtonsoft.Json.JsonProperty("schemaVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemaVersion { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EnvelopeOfStay
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Stay Data { get; set; } = new Stay();

        /// <summary>The point in time when Hapi firstly receives the message from an external system. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("receivedDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime ReceivedDateTime { get; set; }

        /// <summary>The point in time when Hapi firstly created the message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime CreatedDateTime { get; set; }

        /// <summary>The DateTime of last update of a given message in the MongoDB. UTC+0 timezone.</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime LastModifiedDateTime { get; set; }

        /// <summary>The version of the data model that represents the data in the 'data' field.</summary>
        [Newtonsoft.Json.JsonProperty("schemaVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemaVersion { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }
    #endregion

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class SuccessfulResponseExample
    {
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Timestamp { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Status { get; set; }

        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Message { get; set; }

        [Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        
        public string Path { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum AdditionalOccupantsPriceOccupantsType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ADULT")]
        ADULT = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CHILD")]
        CHILD = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"CHILD_1")]
        CHILD_1 = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CHILD_2")]
        CHILD_2 = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CHILD_3")]
        CHILD_3 = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CHILD_4")]
        CHILD_4 = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CHILD_5")]
        CHILD_5 = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GUEST")]
        GUEST = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 8,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum BlockNotificationType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NEW")]
        NEW = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"UPDATE")]
        UPDATE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"DELETE")]
        DELETE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CANCEL")]
        CANCEL = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"DELTA")]
        DELTA = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"OVERLAY")]
        OVERLAY = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 6,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum BlockInventoryCountType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"BLOCKED")]
        BLOCKED = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"PICKED_UP")]
        PICKED_UP = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"AVAILABLE")]
        AVAILABLE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum BlockInventoryCountByOccupantsType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"BLOCKED")]
        BLOCKED = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"PICKED_UP")]
        PICKED_UP = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"AVAILABLE")]
        AVAILABLE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 3,

    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum BookingRuleType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"OPEN")]
        OPEN = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CLOSE")]
        CLOSE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"OPEN_TO_ARRIVAL")]
        OPEN_TO_ARRIVAL = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CLOSE_TO_ARRIVAL")]
        CLOSE_TO_ARRIVAL = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"OPEN_TO_DEPARTURE")]
        OPEN_TO_DEPARTURE = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"CLOSE_TO_DEPARTURE")]
        CLOSE_TO_DEPARTURE = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"MIN_LENGTH_OF_STAY")]
        MIN_LENGTH_OF_STAY = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"MAX_LENGTH_OF_STAY")]
        MAX_LENGTH_OF_STAY = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"MIN_LENGTH_OF_STAY_ON_ARRIVAL")]
        MIN_LENGTH_OF_STAY_ON_ARRIVAL = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"MAX_LENGTH_OF_STAY_ON_ARRIVAL")]
        MAX_LENGTH_OF_STAY_ON_ARRIVAL = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"MIN_DAYS_BEFORE_STAY_DATE")]
        MIN_DAYS_BEFORE_STAY_DATE = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"MAX_DAYS_BEFORE_STAY_DATE")]
        MAX_DAYS_BEFORE_STAY_DATE = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 12,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum ContactDetailsCategory
    {
        [System.Runtime.Serialization.EnumMember(Value = @"PHONE")]
        PHONE = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"EMAIL")]
        EMAIL = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"FAX")]
        FAX = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"SOCIAL_MEDIA")]
        SOCIAL_MEDIA = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum CountryFormat
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ISO_3166_1_ALPHA_2")]
        ISO_3166_1_ALPHA_2 = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"ISO_3166_1_ALPHA_3")]
        ISO_3166_1_ALPHA_3 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"CUSTOM")]
        CUSTOM = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum FinancialTransactionNotificationType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NEW")]
        NEW = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"UPDATE")]
        UPDATE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"DELETE")]
        DELETE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CANCEL")]
        CANCEL = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"DELTA")]
        DELTA = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"OVERLAY")]
        OVERLAY = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 6,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum FinancialTransactionTransactionType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"PAYMENT")]
        PAYMENT = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"DEPOSIT")]
        DEPOSIT = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"POSTING")]
        POSTING = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"TAX")]
        TAX = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"PAID_OUT")]
        PAID_OUT = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"NON_REVENUE")]
        NON_REVENUE = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"ACCCOUNT_RECEIVABLE")]
        ACCCOUNT_RECEIVABLE = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 7,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum FixedChargePostingFrequency
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ONCE")]
        ONCE = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"PER_NIGHT")]
        PER_NIGHT = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PER_WEEK")]
        PER_WEEK = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"PER_MONTH")]
        PER_MONTH = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"PER_QUARTER")]
        PER_QUARTER = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"PER_YEAR")]
        PER_YEAR = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 6,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum FixedChargePostingDayOfWeek
    {
        [System.Runtime.Serialization.EnumMember(Value = @"MONDAY")]
        MONDAY = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"TUESDAY")]
        TUESDAY = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"WEDNESDAY")]
        WEDNESDAY = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"THURSDAY")]
        THURSDAY = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"FRIDAY")]
        FRIDAY = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"SATURDAY")]
        SATURDAY = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"SUNDAY")]
        SUNDAY = 6,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum GuestType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"GUEST")]
        GUEST = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CONTACT")]
        CONTACT = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum GuestNotificationType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NEW")]
        NEW = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"UPDATE")]
        UPDATE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"DELETE")]
        DELETE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CANCEL")]
        CANCEL = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"DELTA")]
        DELTA = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"OVERLAY")]
        OVERLAY = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 6,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum GuestStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ACTIVE")]
        ACTIVE = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"INACTIVE")]
        INACTIVE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"MARKED_FOR_DELETION")]
        MARKED_FOR_DELETION = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"ANONYMIZED")]
        ANONYMIZED = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum GuestGender
    {
        [System.Runtime.Serialization.EnumMember(Value = @"MALE")]
        MALE = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"FEMALE")]
        FEMALE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum InventoryCountType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"PHYSICAL")]
        PHYSICAL = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"AVAILABLE")]
        AVAILABLE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"DEFINITE_SOLD")]
        DEFINITE_SOLD = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"TENTATIVE_SOLD")]
        TENTATIVE_SOLD = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"OUT_OF_ORDER")]
        OUT_OF_ORDER = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 5,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum LanguageFormat
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ISO_639_1")]
        ISO_639_1 = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"ISO_639_2")]
        ISO_639_2 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"ISO_639_3")]
        ISO_639_3 = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CUSTOM")]
        CUSTOM = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum OccupantsType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ADULT")]
        ADULT = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CHILD")]
        CHILD = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"CHILD_1")]
        CHILD_1 = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CHILD_2")]
        CHILD_2 = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CHILD_3")]
        CHILD_3 = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CHILD_4")]
        CHILD_4 = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CHILD_5")]
        CHILD_5 = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GUEST")]
        GUEST = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 8,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum PersonNameType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"FORMER")]
        FORMER = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"NICKNAME")]
        NICKNAME = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"ALTERNATE")]
        ALTERNATE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"MAIDEN")]
        MAIDEN = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum ProfileType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"COMPANY")]
        COMPANY = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"TRAVEL_AGENT")]
        TRAVEL_AGENT = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"GROUP")]
        GROUP = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CORPORATE")]
        CORPORATE = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"SOURCE")]
        SOURCE = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 5,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum ProfileNotificationType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NEW")]
        NEW = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"UPDATE")]
        UPDATE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"DELETE")]
        DELETE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CANCEL")]
        CANCEL = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"DELTA")]
        DELTA = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"OVERLAY")]
        OVERLAY = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 6,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum ProfileStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ACTIVE")]
        ACTIVE = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"INACTIVE")]
        INACTIVE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"MARKED_FOR_DELETION")]
        MARKED_FOR_DELETION = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"ANONYMIZED")]
        ANONYMIZED = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum ProfileNameType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"PRIMARY")]
        PRIMARY = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"SECONDARY")]
        SECONDARY = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"TERTIARY")]
        TERTIARY = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"ALTERNATE")]
        ALTERNATE = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum RateNotificationType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NEW")]
        NEW = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"UPDATE")]
        UPDATE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"DELETE")]
        DELETE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CANCEL")]
        CANCEL = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"DELTA")]
        DELTA = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"OVERLAY")]
        OVERLAY = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 6,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum RateStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ACTIVE")]
        ACTIVE = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"INACTIVE")]
        INACTIVE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"INITIAL")]
        INITIAL = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum RatePricingStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ACTIVE")]
        ACTIVE = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"INACTIVE")]
        INACTIVE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum ReferenceIdIdType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"CONFIRMATION_NUMBER")]
        CONFIRMATION_NUMBER = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"RESERVATION_ID")]
        RESERVATION_ID = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"ORIGINAL_RESERVATION_ID")]
        ORIGINAL_RESERVATION_ID = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CANCELLATION_NUMBER")]
        CANCELLATION_NUMBER = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"PROFILE_ID")]
        PROFILE_ID = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"GUEST_ID")]
        GUEST_ID = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"SHARE_ID")]
        SHARE_ID = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"BLOCK_ID")]
        BLOCK_ID = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"BLOCK_CODE")]
        BLOCK_CODE = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"RATE_ID")]
        RATE_ID = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"STAY_ID")]
        STAY_ID = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"TRANSACTION_ID")]
        TRANSACTION_ID = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 12,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum ReservationNotificationType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NEW")]
        NEW = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"UPDATE")]
        UPDATE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"DELETE")]
        DELETE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CANCEL")]
        CANCEL = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"DELTA")]
        DELTA = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"OVERLAY")]
        OVERLAY = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 6,

    }

    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum ReservationStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"REQUESTED")]
        REQUESTED = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"RESERVED")]
        RESERVED = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"TENTATIVE")]
        TENTATIVE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"OPTIONAL")]
        OPTIONAL = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"CANCELLED")]
        CANCELLED = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"NO_SHOW")]
        NO_SHOW = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"WAITLISTED")]
        WAITLISTED = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"IN_HOUSE")]
        IN_HOUSE = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"CHECKED_OUT")]
        CHECKED_OUT = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 9,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum SegmentationType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"MARKET")]
        MARKET = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CHANNEL")]
        CHANNEL = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"SOURCE")]
        SOURCE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"ORIGIN")]
        ORIGIN = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum ServiceFrequency
    {
        [System.Runtime.Serialization.EnumMember(Value = @"PER_STAY")]
        PER_STAY = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"PER_NIGHT")]
        PER_NIGHT = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PER_WEEK")]
        PER_WEEK = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"PER_USE")]
        PER_USE = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"PER_ADULT_PER_NIGHT")]
        PER_ADULT_PER_NIGHT = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"PER_PERSON_PER_NIGHT")]
        PER_PERSON_PER_NIGHT = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 6,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum StayNotificationType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NEW")]
        NEW = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"UPDATE")]
        UPDATE = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"DELETE")]
        DELETE = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CANCEL")]
        CANCEL = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"DELTA")]
        DELTA = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"OVERLAY")]
        OVERLAY = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 6,

    }
}