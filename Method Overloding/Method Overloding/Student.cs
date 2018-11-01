using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloding
{
    class Student
    {
        private int age;
        public  Student(int a)
        {
            age = a;
        }
        public Student()
        {
            age = 0;
        }

        public void Show()
        {
            Console.WriteLine(age);
        }
        public void Show(string msg)
        {
            Console.WriteLine(msg+age);
        }
        public void Show(int age,string msg)
        {
            Console.WriteLine(age+msg);
        }
    }
}
