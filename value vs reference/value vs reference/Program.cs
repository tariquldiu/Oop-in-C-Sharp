using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_vs_reference
{
   class Student
    {
        public int age;
        public int marks;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
                std.age=20;
                std.marks=100;
                Student std2 = std;
                Student std3 = std;

                std.age = 24;
               // std2.age = 24; // for stack
                Console.WriteLine(std2.age);
                Console.ReadKey();
        }
    }
}
