using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLifeInInheritance
{
    class Product
    {
        public int ID { get; set; }
        public string Nmae { get; set; }
        public int Price { get; set; }

        public Product()
        {
            Console.WriteLine("Product");
        }
    }
    
}
