using Response; 
using System;

namespace Teste
{
    class Program
    { 
        public Program(IResponse response)
        {
            var result = response.Ok("");
        }

        static void Main(string[] args)
        {

        }
    }
}
