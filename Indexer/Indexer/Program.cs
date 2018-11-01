using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std[3] = 6;
            Console.ReadKey();
        }
    }
}
