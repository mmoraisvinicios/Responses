using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Response
{
    public class Response<T> : Response
    {
        protected Response() { }

        public T @Object { get; internal set; }

        public override Response Result()
        {
            return Create(Successfully, HasError, _error, @Object);
        }


        public Response Create(bool successfully, bool hasError, List<Error> error,
            T @object)
        {
            return new Response<T>()
            {
                _error = error,
                HasError = hasError,
                Successfully = successfully,
                @Object = @object
            };
        }

        public Response(T @object)
        {
            _error = null;
            HasError = false;
            Successfully = true;
            this.Object = @object;
        }
         
    }

    public class Response : ResultOperation, IResponse
    {
        internal List<Error> _error = new List<Error>();
         
        public override Response Result() => 
            Create(Successfully, HasError, _error);
        

        public Response Create(bool successfully, bool hasError, List<Error> error)
        {
            return new Response()
            {
                _error = error,
                HasError = hasError,
                Successfully = successfully
            };
        }

        public bool Successfully { get; protected set; } 
        public  IList<Error> Error => _error;
        public bool HasError { get; protected set; }

        public Response()
        {
            HasError = false;
            _error = null;
            Successfully = true;
        } 
         
        public Response Ok() => new Response();

        public Response<T> Ok<T>(T obj) => new Response<T>(obj);

        public void AddError(Error error)
            => Fail(error);

        public void AddError(string error)
            => Fail(JsonConvert.DeserializeObject<Error>(error));

        private void Fail(Error error)
        {
            Successfully = false;
            HasError = true;
            _error.Add(error);
        }

    }



}
