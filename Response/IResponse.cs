using System;
using System.Collections.Generic;
using System.Text;

namespace Response
{
    public interface IResponse
    {
         
        ResponseModel Ok();
        ResponseModel<T> Ok<T>(T obj);
        void AddError(string error);
        void AddError(Error error);
    }
}
