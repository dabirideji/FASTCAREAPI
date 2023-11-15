using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FastCare.Domain.Models.Categories
{
      [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MedicalFacilityType
    {
        [EnumMember(Value = "Hospital")]
        Hospital,
        
        [EnumMember(Value = "Clinic")]
        Clinic,
        
        [EnumMember(Value = "Laboratory")]
        Laboratory,
        
    }
}