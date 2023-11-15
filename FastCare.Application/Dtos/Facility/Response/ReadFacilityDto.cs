using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Domain.Models.Categories;

namespace FastCare.Application.Dtos.Facility.Response
{
    public class ReadFacilityDto
    {
        public Guid Id { get; set; }
        public String? Name { get; set; }
        public MedicalFacilityType FacilityType { get; set; }

        public String? Location { get; set; }
        public double BookingPrice { get; set; }

        public FacilityAvailabilityStatus IsAvailable { get; set; }
        public int Ratings { get; set; }
        public List<MedicalFacilityServiceType>? Services { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
