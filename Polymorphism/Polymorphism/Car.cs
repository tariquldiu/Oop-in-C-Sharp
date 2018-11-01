using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car:Transformer
    {
        public override void Run()
        {
            Console.WriteLine("Run Car");
        }
    }
}
