using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastCare.Application.Dtos.Doctor.Request
{
    public class CreateDoctorDto
    {
         [Range(0, 5, ErrorMessage = "Ratings must be between 0 and 5.")]
        public int Ratings { get; set; }
        //USER ID COMING SOON
         [Range(0, 40, ErrorMessage = "Reasonable Experience must be between 0 and 40.")]
           public int Experience { get; set; }
        
        public String? Degree { get; set; }
        public String? Bio { get; set; }
        public String? Location { get; set; }
    }
}