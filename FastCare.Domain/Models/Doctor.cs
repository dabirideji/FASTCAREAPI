using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastCare.Domain.Models
{
    public class Doctor
    {
        [Key]
        public Guid DoctorId { get; set; }
        //USER ID COMING SOON

        public int DoctorRatings { get; set; }
        public int DoctorExperience { get; set; }
        
        public String? DoctorDegree { get; set; }
        public String? DoctorBio { get; set; }
        public String? DoctorLocation { get; set; }
    }
}
