using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.com.Composition
{
    class University
    {
        public ArtDepartment Art { get; set; }
        public CompDepartment Comp { get; set; }

        public void IniArtDept(string name, int noOfStd, string artDirec)
        {
            this.Art = new ArtDepartment();
            Art.Name = name;
            Art.ArtDirector = artDirec;
            Art.NoOfStudent = noOfStd;
        }
        public void IniCompDept(string name,int noOfCompLab,string compDirec)
        {
            this.Comp = new CompDepartment();
            Comp.Name = name;
            Comp.CompDirector = compDirec;
            Comp.NoOfComputerLab = noOfCompLab;
        }
    }
}
