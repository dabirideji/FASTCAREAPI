using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastCare.Application.Dtos.Drug.Request
{
    public class UpdateDrugDto
    {
          public String? DrugName { get; set; }
        public int DrugWeight { get; set; }
        public int DrugVolume { get; set; }
        public double DrugPrice { get; set; }
        public String? DrugDescription { get; set; }
        public String? DrugImage { get; set; }
        public String? DrugManufacturer { get; set; }
    }
}