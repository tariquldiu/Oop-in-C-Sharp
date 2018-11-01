using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorParamiterLifeInInheritance
{
    class Product
    {
        public int ID { get; set; }
        public string Nmae { get; set; }
        public int Price { get; set; }

        public Product(string name)
        {
            this.Nmae = name;
        }
        public void Show()
        {
            Console.WriteLine("Product Show");
        }
    }
    
}
