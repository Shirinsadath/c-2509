using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment_1
{
    public class Rectangle
    {
        public void ToCalculateArea(int Width, int Height)
        {
            int Area = Width * Height;
            Console.WriteLine($"area of recatangle {Area}");
        }
        public void ToCalculateArea(double Length)
        {
            double area = Length * Length;
            Console.WriteLine($"Area of square is {area}");

        }

    }
}
