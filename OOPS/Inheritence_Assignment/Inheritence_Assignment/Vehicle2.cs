using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment
{
    public abstract class Vehicle2
    {
        public abstract void Drive();
    }

    public class Car : Vehicle2
    {
        public override void Drive()
        {
            Console.WriteLine("The car is driving on the road.");
        }
    }


    public class Bike : Vehicle2
    {
        public override void Drive()
        {
            Console.WriteLine("The bike is zooming through the streets.");
        }

    }
}

