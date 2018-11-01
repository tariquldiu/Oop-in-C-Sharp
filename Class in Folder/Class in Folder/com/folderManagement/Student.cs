using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_in_Folder.com.folderManagement
{
    class Student
    {
        public string Name;
        public int Age;
        public int Marks;

        public void details()
        {
            Console.WriteLine("Name={0} Age={1} Marks={2}",Name,Age,Marks);
            Console.ReadKey();
        }
    }
}
