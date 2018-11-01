using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloding
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student(24);
            std.Show("My age is ");
            Console.ReadKey();
        }
    }
}
