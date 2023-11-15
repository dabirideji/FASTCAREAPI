using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastCare.Application.Dtos.Doctor.Response
{
    public class ReadDoctorDto
    {
        public Guid DoctorId { get; set; }
        //USER ID COMING SOON
        //USER ALSO COMING SOON
        public int DoctorRatings { get; set; }
        public int DoctorExperience { get; set; }

        public String? DoctorDegree { get; set; }
        public String? DoctorBio { get; set; }
        public String? DoctorLocation { get; set; }
    }
}
