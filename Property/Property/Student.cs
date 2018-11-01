using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Student
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {


                if (value > 0)
                {

                age = value;
                Console.WriteLine(age);
                }
                else
                {
                    Console.WriteLine("Don't enter invalid value....");
                }
            }
        }


    }
}
