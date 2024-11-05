using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_ASSIGNMENT4_abstract__partial__interface
{
    public enum CarType
    {
        Sedan, SUV, Truck, Van
    }
    public class Car3
    {
        public CarType Type
        { get; set; }
        public Car3(CarType type) 
        { 
            Type = type; 
        }
        public void DisplayCarType(CarType carType)
        {
            switch (carType)
            {
                case CarType.Sedan:
                    Console.WriteLine("This car is a Sedan");
                    break;
                case CarType.SUV:
                    Console.WriteLine("This car is an SUV");
                    break;
                case CarType.Truck:
                    Console.WriteLine("This car is a Truck");
                    break;
                case CarType.Van:
                    Console.WriteLine("This car is a Van");
                    break;
            }

        }
    }
    }
