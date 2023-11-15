using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Domain.Models.Categories;

namespace FastCare.Domain.Models
{
    public class MedicalPracticioner
    {
        
        public int Ratings { get; set; }
        public int Experience { get; set; }
        //USER ID COMING SOON
        public MedicalPracticionerType MedicalAccountType { get; init; }
        public String? Degree { get; set; }
        public String? Bio { get; set; }
        public String? Location { get; set; }
    }
}