using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment
{
    public interface IMovable
    {
        void Move();
    }

    public interface IRechargeable
    {
        void Recharge();
    }

    public class Vehicle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The vehicle is moving.");
        }
    }

    public class ElectricCar : Vehicle, IRechargeable
    {
        public void Recharge()
        {
            Console.WriteLine("The electric car is recharging.");
        }


        public new void Move()
        {
            Console.WriteLine("The electric car is silently moving.");
        }

    }
}
