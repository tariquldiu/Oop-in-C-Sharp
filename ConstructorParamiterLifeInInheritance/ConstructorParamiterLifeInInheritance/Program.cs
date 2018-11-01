using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorParamiterLifeInInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Hardware hd = new Hardware("Motherbord");

            hd.Show();
            Console.ReadKey();
        }
    }
}
