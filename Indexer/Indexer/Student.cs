using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Student
    {
        private int[] array = { 14, 2, 7, 12, 20, 5 };

        public int this[int index]
        {
            get {
                if (index >= 0 & index < array.Length)
                {
                return array[index];

                }
                else
                {
                    Console.WriteLine("Wrong Index");
                }
                return 0;

                /* return the specified index here */
            }
            set {
                if (index >= 0 & index < array.Length)
                {
                
                 if (index>0)
                 {
                     array[index] = value;
                 }
                 else
                 {
                     Console.WriteLine("Invalid data...");
                 }
                }
                else
                {
                    Console.WriteLine("Wrong Index");
                }
                /* set the specified index to value here */ 
            }
        }
    }
}
