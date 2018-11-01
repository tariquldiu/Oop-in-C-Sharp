using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism___Interface.com.purePolymorphism;

namespace Polymorphism___Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ITranceformer trns = new Car();
            trns.Run();

            trns = new Boat();
            trns.Run();

            trns = new Helicopter();
            trns.Run();

            Console.ReadKey();
        }
    }
}
