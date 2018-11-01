using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implementation
{
    interface ITransformer
    {
        void Run();

    }
    interface IExample
    {
        void Run();

    }
    class Car : ITransformer, IExample
    {
        void IExample.Run()
        {
            Console.WriteLine("Run Example.....");
        }

        void ITransformer.Run()
        {
            Console.WriteLine("Run Transformer.....");
        }
    }

}
