using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment_1
{
    public class Cars
    {
        public string model;
        public int year;
        public Cars(string model, int year)
        {
            this.model = model;
            this.year = year;
        }
        public Cars(Cars CarToCopy)
        {
            model = CarToCopy.model;
            year = CarToCopy.year;
        }
        public void Display()
        {
            Console.WriteLine("CAR MODEL : CAR YEAR");
            Console.WriteLine($"{model} : {year}");
        }

    }
}
