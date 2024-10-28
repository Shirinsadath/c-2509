using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment_1
{
    public class Car1
    {
        public string Make;
        public string Model;
        public int Year;
        public double Price;

        public Car1(string make) 
        {
            this.Make = make;
            this.Model = "unknown";
            this.Year = 0;
            this.Price = 0;

        }
        public Car1(string make, string model)
        {
            this.Make = make;
            this.Model = model;
            this.Year = 0;
            this.Price = 0;
        }
        public Car1(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = 0;
        }
        public Car1(string make, string model, int year, double price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }
        public void Display()
        {
            Console.WriteLine($"Make : {Make}, Model : {Model}, Year : {Year}, Price : {Price}");
        }
        }
}
