using System;
using System.Collections.Generic;
using System.Text;

namespace Response
{
    public class ResponseModel<T> : ResponseModel
    {
        public ResponseModel(T @object)
        {
            @Object = @object;
        }

        public T @Object { get; internal set; }

        public static ResponseModel<T> Create(bool successfully, bool hasError, List<Error> error, T @object)
        {
            return new ResponseModel<T>(@object)
            {
                @Object = @object,
                _error = error,
                HasError = hasError,
                Successfully = successfully
            };
        }
    }

    public class ResponseModel
    {
        internal List<Error> _error = new List<Error>();
        public IList<Error> Error => _error;
        public bool HasError { get; protected set; }
        public bool Successfully { get; protected set; }

         

        public static ResponseModel Create(bool successfully, bool hasError, List<Error> error)
        {
            return new ResponseModel()
            {
                _error = error,
                HasError = hasError,
                Successfully = successfully
            };
        }

      

    }
}
