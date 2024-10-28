using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment
{
    class Vehicle3
    {
        public string Brand { get; }

        public Vehicle3(string brand)
        {
            Brand = brand;
        }
    }
    class Car3 : Vehicle3
    {
        public Car3(string brand) : base(brand)
        {
        }
        public void ShowBrand()
        {
            Console.WriteLine($"Car Brand: {Brand}");
        }
    }
}
