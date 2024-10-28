using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment
{
    public interface IDriveable
    {
        void Drive();
    }
    public interface IRaceable : IDriveable
    {
        void Race();
    }
    public class SportsCar : IRaceable
    {
        public void Drive()
        {
            Console.WriteLine("Driving the sports car.");
        }
        public void Race()
        {
            Console.WriteLine("Racing the sports car.");
        }
    }

}
