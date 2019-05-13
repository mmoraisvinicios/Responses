using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Response
{  
    public class Response : IResponse
    {
        private readonly ResponseModel response;

        public ResponseModel Fail() => ResponseModel.Create(false, response._error);
        public ResponseModel Fail(Error error)
        {
            AddError(error);
            return ResponseModel.Create(false, response._error);
        }

        public ResponseModel Ok() => ResponseModel.Create(true, null);

        public ResponseModel<T> Ok<T>(T obj) => 
            ResponseModel<T>.Create(true, null, obj);


        public void AddError(Error error) =>
            response._error.Add(error);

        public void AddError(string error) => 
            AddError(JsonConvert.DeserializeObject<Error>(error));

    }

}
