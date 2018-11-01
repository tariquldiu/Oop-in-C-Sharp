using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            ITransformer trns = car;
            trns.Run();

            IExample exm = car;
                exm.Run();

            Console.ReadKey();
        }
    }
}
