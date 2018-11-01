using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_in_a_Class
{
    class Program
    {
        public class Box
        {
            public int height;
            public int width;
            public int depth;
            public string  name;
            public double price;

            public void getValue(int h,int w,int d,string n,double p)
            {
                height = h;
                width = w;
                depth = d;
                name = n;
                price = p;
            }
            public int getArea()
            {
                return height * width * depth;
            }
            public void getDisplay()
            {
                Console.WriteLine("Name:"+name);
                Console.WriteLine("Height:" + height);
                Console.WriteLine("Width:"+width);
                Console.WriteLine("Depth:"+depth);
                Console.WriteLine("Area:"+getArea());
                Console.WriteLine("Price:"+price);

            }

        }
        static void Main(string[] args)
        {

            Box bx = new Box();
            Console.Write("Enter tha height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter tha width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter tha depth:");
            int depth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter tha name:");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter tha price:");
            double price = Convert.ToDouble(Console.ReadLine());

            bx.getValue(height, width, depth, name, price);
            bx.getDisplay();
    
            Console.ReadKey();
        }
    }
}
