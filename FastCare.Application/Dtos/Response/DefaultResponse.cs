using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastCare.Application.Dtos.Response
{
    public class DefaultResponse<T>
    {
        public bool Status { get; set; }
        public String ResponseCode { get; set; }
        public String ResponseMessage { get; set; }
        public T Data { get; set; }
    }
}