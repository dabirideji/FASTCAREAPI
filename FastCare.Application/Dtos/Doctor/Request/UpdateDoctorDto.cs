using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastCare.Application.Dtos.Doctor.Request
{
    public class UpdateDoctorDto
    {
        [Range(0, 5, ErrorMessage = "Ratings must be between 0 and 5.")]
        public int DoctorRatings { get; set; }
        public int DoctorExperience { get; set; }

        public String? DoctorDegree { get; set; }
        public String? DoctorBio { get; set; }
        public String? DoctorLocation { get; set; }
    }
}
