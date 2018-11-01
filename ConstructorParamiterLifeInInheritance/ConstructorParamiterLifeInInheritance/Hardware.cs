using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorParamiterLifeInInheritance
{
    class Hardware : Product
    {
        public string GaranteeDate { get; set; }

        public Hardware(string n):base(n)
        {
         
        }
       new  public void Show()
        {
            Console.WriteLine("Hardware Show");
        }
    }
}
