using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_in_Folder.com.folderManagement;

namespace Class_in_Folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Name = "Tariqul Islam";
            std.Age = 23;
            std.Marks = 100;

            std.details();

        }
    }
}
