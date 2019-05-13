using System;
using System.Collections.Generic;
using System.Text;

namespace Response
{
    public interface IResponse
    {
        ResponseModel Fail();
        ResponseModel Fail(Error error);

        ResponseModel Ok();
        ResponseModel<T> Ok<T>(T obj);
         
        void AddError(string error);
        void AddError(Error error);
    }
}
