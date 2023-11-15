using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FastCare.Domain.Models.Categories
{
   [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FacilityAvailabilityStatus
    {
        [EnumMember(Value = "ComingSoon")]
        ComingSoon,

        [EnumMember(Value = "Pending")]
        Pending,

        [EnumMember(Value = "Suspended")]
        Suspended,

        [EnumMember(Value = "Available")]
        Available,

        [EnumMember(Value = "BookedOut")]
        BookedOut,

        [EnumMember(Value = "Closed")]
        Closed,

        [EnumMember(Value = "UnderMaintenance")]
        UnderMaintenance,

        [EnumMember(Value = "NotAvailable")]
        NotAvailable,

        // Add more availability statuses as needed
    }
}