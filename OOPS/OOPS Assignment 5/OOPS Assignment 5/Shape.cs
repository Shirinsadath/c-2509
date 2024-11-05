using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment_5
{
    public struct Circle
    {
        public double Radius { get; set; } 
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public void Display()
        {
            double Area = 3.14 * Radius * Radius;
            Console.WriteLine($"Area of the circle : {Area}");
        }
    }
    public class Shape
    {
        public double Size { get; set; }
    }
}
