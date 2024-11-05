using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_ASSIGNMENT4_abstract__partial__interface
{
    abstract class Vehicle
    {
        public abstract void StartEngine();
        public void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }
    }
    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine has started");
        }
    }
    class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine has started");
        }
    }
}
