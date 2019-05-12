using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Response
{
    public class Response<T> : Response
    {
        private ResponseModel<T> response;

        public override ResponseModel Result()
        {
            response = ResponseModel<T>.Create(response.Successfully, response.HasError, response._error, response.Object);
            return response;
        } 
    }

    public class Response : ResultOperation
    {
        private ResponseModel response;

        public override ResponseModel Result()
        {
            response = ResponseModel.Create(response.Successfully, response.HasError, response._error);
            return response;
        }
    }
     
}
