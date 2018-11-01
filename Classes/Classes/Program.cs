using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        class Student
        {
           public string Name;
           public int Age;
           public int Mark;

           public void details()
            {
                Console.WriteLine("Name={0} Age={1} Mark={2}" , Name,Age,Mark);
                Console.ReadKey();
            }

        }
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Name="Tariqul";
            std.Age = 24;
            std.Mark = 85;
            std.details();
        }
    }
}
