using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptulation
{
    class Student
    {
        private string Name;
        private int Age;
        private int Marks;

        public void setName(string n)
        {
            if (!string.IsNullOrEmpty(n))
            {
                Name = n;
            }
            else
            {
                Console.WriteLine("You can't enter null or empty value..");
            }
        }
         public void setAge(int a)
         {
            if (a>0)
            {
               Age = a;
            }
            else
            {
                Console.WriteLine("You've enter invalid value,plz... try again later...");
            }
         }
          public void setMarks(int m)
         {
            if(m>0)
            {
                Marks = m;
            }
            else
            {
                Console.WriteLine("You've enter invalid value,plz... try again later...");
            }
        }
         public void details()
         {
             Console.WriteLine("Name={0} Age={1} Marks={2}", Name , Age , Marks);
             Console.ReadKey();
         }
    }
}
