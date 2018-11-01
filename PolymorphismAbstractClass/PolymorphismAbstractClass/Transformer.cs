using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstractClass
{
   abstract class Transformer
    {
       public Transformer()
       {
           Console.WriteLine("Constructor");
       }
       public void Show()
       {
           Console.WriteLine("Show");
       }
       public abstract void Run();


    }
    class Car:Transformer
    {
        public override void Run()
        {
            Console.WriteLine("Run Car");
        }
    }
    class Boat:Transformer
    {
        public override void Run()
        {
            Console.WriteLine("Run Boat");
        }
    }
    class Helicopter:Transformer
    {
        public override void Run()
        {
            Console.WriteLine("Run Helicopter");
        }
    }
}
