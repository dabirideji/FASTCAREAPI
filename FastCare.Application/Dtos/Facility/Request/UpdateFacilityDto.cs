using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Domain.Models.Categories;

namespace FastCare.Application.Dtos.Facility.Request
{
    public class UpdateFacilityDto
    {
        [Required]
        public String? Name { get; set; }
        [Required]
        public MedicalFacilityType FacilityType { get; set; }
        [Required]
        public String? Location { get; set; }
        [Required]
        public double BookingPrice { get; set; }
        [Required]
        public FacilityAvailabilityStatus Availability { get; set; }
        [Required]
         [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
        public int Ratings { get; set; }
        public List<MedicalFacilityServiceType>? Services { get; set; }
    }
}