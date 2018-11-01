using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composition.com.Composition;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            University uni = new University();
            uni.IniArtDept("SADA", 100, "Tariqul");
            uni.IniCompDept("FSIT", 500, "Tariqul Islam");
            Console.ReadKey();
        }
    }
}
