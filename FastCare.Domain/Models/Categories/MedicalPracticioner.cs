using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FastCare.Domain.Models.Categories
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MedicalPracticionerType
    {
        [EnumMember(Value = "MedicalDoctor")]
        MedicalDoctor,
        [EnumMember(Value = "Nurse")]
        Nurse,
        [EnumMember(Value = "Surgeon")]
        Surgeon,
        [EnumMember(Value = "LabTechnician")]
        LaboratoryTechnician
    }
}