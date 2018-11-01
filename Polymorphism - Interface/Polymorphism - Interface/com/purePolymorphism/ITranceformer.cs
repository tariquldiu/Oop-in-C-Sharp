using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism___Interface.com.purePolymorphism
{
    interface ITranceformer
    {
        void Run();
    }
    class Car:ITranceformer
    {

        public void Run()
        {
            Console.WriteLine("Run Car");
        }
    }
    class Boat : ITranceformer
    {
        public void Run()
        {
            Console.WriteLine("Run Boat");
        }
    }
    class Helicopter : ITranceformer
    {
        public void Run()
        {
            Console.WriteLine("Run Helicopter");
        }
    }


}
