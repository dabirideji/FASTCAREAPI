using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Domain.Models.Categories;

namespace FastCare.Domain.Models
{
    public class Facility
    {
        [Key]
        public Guid Id { get; set; }
        public String? Name { get; set; }
        public MedicalFacilityType FacilityType { get; set; }

        public String? Location { get; set; }
        public double BookingPrice { get; set; }

        public FacilityAvailabilityStatus Availability { get; set; }
        public int Ratings { get; set; }
        [NotMapped]
        public IEnumerable<MedicalFacilityServiceType>? Services { get; set; }
        public DateTime CreatedAt { get; init; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
