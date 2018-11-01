using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLifeInInheritance
{
    class Hardware:Product
    {
        public string GaranteeDate { get; set; }

        public Hardware(){
            Console.WriteLine("Hardware");
    }
    }
}
