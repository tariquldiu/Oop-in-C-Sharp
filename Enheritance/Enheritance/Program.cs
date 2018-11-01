using Enheritance.com.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Food ft = new Food();
            ft.ID = 1;
            ft.Nmae = "Coffiee";
            ft.Price = 25;
            //ft.Exp = 10. 02. 2018;
            Furniture fur = new Furniture();
            fur.ID = 1;
            fur.Nmae = "Chair";
            fur.Price = 1200;
            fur.WoodType = "U-Caliptus";

            Console.WriteLine(fur.WoodType);
            Console.WriteLine(ft.Nmae);
            Console.ReadKey();
        }
       
        
    }
}
