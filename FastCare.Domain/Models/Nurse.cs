using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Domain.Models.Categories;

namespace FastCare.Domain.Models
{
    public class Nurse:MedicalPracticioner
    {
          [Key]
        public Guid NurseId { get; set; }

        //USER ID COMING SOON
        protected MedicalPracticionerType MedicalAccountType { get; init; }=MedicalPracticionerType.Nurse;

    }
}