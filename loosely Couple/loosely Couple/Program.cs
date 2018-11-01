using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loosely_Couple.com.Composition;


namespace loosely_Couple
{
    class Program
    {
        static void Main(string[] args)
        {
            University uni = new University();
            uni.AddDepartment("FSIT","Tariqul",Dep.comp,150);
            uni.AddDepartment("SADA", "Nayon", Dep.art, 50);

            foreach (var item in uni.departments)
            {
                if(item is ArtDepartment)
                {
                    ArtDepartment art=(ArtDepartment)item;
                    Console.WriteLine("Dep Name{0} Director Name:{1} Number of Students",art.Name,art.Director,art.NoOfStudent);
                }
                else if (item is CompDepartment)
                {
                    CompDepartment comp = (CompDepartment)item;
                    Console.WriteLine("Dep Name{0} Director Name:{1} Number of Students",comp.Name,comp.Director,comp.NoOfComputerLab);
                }
            }
            Console.ReadKey();
        }

    }
}
