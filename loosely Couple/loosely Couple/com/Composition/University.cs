using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using loosely_Couple.com.Composition;

namespace loosely_Couple.com.Composition
{
    enum Dep{
        art,
        comp,
com
    }
    class University
    {

        public List<Department> departments { get; set; }=new List<Department>();

        public void AddDepartment(string name,string director,Dep dep,int num)
        {
            if(dep==Dep.art)
            {
                ArtDepartment art=new ArtDepartment();
                art.Name=name;
                art.Director=director;
                art.NoOfStudent=num;
                departments.Add(art);
            }
            else if(dep==Dep.comp)
            {
                CompDepartment comp=new CompDepartment();
                comp.Name=name;
                comp.Director=director;
                comp.NoOfComputerLab=num;
                departments.Add(comp);
            }

        }

    }
}
