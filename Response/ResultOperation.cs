using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Response
{
    public abstract class ResultOperation : IResponse
    {
        public ResponseModel Ok() => new ResponseModel();

        public ResponseModel<T> Ok<T>(T obj) => new ResponseModel<T>(obj);

        public void AddError(Error error)
        {

        }
        //=> Fail(error);

        public void AddError(string error)
        {

        }
        //=> Fail(JsonConvert.DeserializeObject<Error>(error));

        public abstract ResponseModel Result();


        //private void Fail(Error error)
        //{
        //    Successfully = false;
        //    HasError = true;
        //    _error.Add(error);
        //}

    }
}
