using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Student
    {
        public int Age;
        public string Name;

        public void setValues(int Age,string Name)
        {
            this.Age = Age;
            this.Name = Name;
            Console.WriteLine(Age+ Name);
        }
    }
}
