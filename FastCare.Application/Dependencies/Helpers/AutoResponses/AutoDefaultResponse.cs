using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Application.Dtos.Response;

namespace FastCare.Application.Dependencies.Helpers.AutoResponses
{
    public class AutoDefaultResponse<T>
    {
        public DefaultResponse<T> ConvertToGood(String message){
            return new DefaultResponse<T>(){
                Status=true,
                ResponseCode="00",
                ResponseMessage=message
            };
        }
        public DefaultResponse<T> ConvertToBad(String message){
            return new DefaultResponse<T>(){
                Status=false,
                ResponseCode="99",
                ResponseMessage=message
            };
        }
    }
}