using Response; 
using System;

namespace Teste
{
    class Program
    { 
        public Program(IResponse response)
        {
            var result = response.Fail();
        }

        static void Main(string[] args)
        {

        }
    }
}
