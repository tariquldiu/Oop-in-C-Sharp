using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.setName("Tariqul");
            std.setAge(24);
            std.setMarks(85);

            std.details();
        }
    }
}
