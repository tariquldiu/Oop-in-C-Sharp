using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Student
    {
        private int Age;
        public Student(int a)
        {
            Age = a;

            
        }
        public void show()
        {
            Console.WriteLine("Age is:{0}",Age);
            Console.ReadKey();
        }
    }
}
