using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Its a vehicle...");
        }

    }
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Its a car...");
        }
    }
}
