using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FastCare.Domain.Models.Categories
{
 [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MedicalFacilityServiceType
    {
        [EnumMember(Value = "DiagnosticImaging")]
        DiagnosticImaging,

        [EnumMember(Value = "EmergencyCare")]
        EmergencyCare,

        [EnumMember(Value = "LaboratoryTesting")]
        LaboratoryTesting,

        [EnumMember(Value = "Pharmacy")]
        Pharmacy,

        [EnumMember(Value = "PrimaryCare")]
        PrimaryCare,

        [EnumMember(Value = "MRIScans")]
        MRIScans,

        [EnumMember(Value = "CTScans")]
        CTScans,

        [EnumMember(Value = "FirstAid")]
        FirstAid,

        [EnumMember(Value = "Surgery")]
        Surgery,

        [EnumMember(Value = "IntensiveCare")]
        IntensiveCare,

        
    }

}