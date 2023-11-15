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
        public int Ratings { get; set; }
        public int Experience { get; set; }

        public String? Degree { get; set; }
        public String? Bio { get; set; }
        public String? Location { get; set; }
    }
}
