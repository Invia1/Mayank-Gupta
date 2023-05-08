using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVariable
{
    internal class AreaOfCircle
    {
        double area;
        int radius;
        const double pie = 3.14; 

        public void calculateArea(double r)
        {
            area = r * r * 3.14;
            Console.WriteLine("area of circle {0} which radius is {1}",area,r);
        }
        static void Main(string[] args)
        {
            AreaOfCircle c1= new AreaOfCircle();
            Console.WriteLine("enter radius");
            int R=Convert.ToInt32(Console.ReadLine());
            c1.calculateArea(R);
            Console.ReadLine();
        }
      
    }
}