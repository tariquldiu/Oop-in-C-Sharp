using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Transformer trns = new Car();
            trns.Run();

            trns = new Boat();
            trns.Run();

            trns = new Helicopter();
            trns.Run();

            trns.Show();
            Console.ReadKey();
        }
    }
}
