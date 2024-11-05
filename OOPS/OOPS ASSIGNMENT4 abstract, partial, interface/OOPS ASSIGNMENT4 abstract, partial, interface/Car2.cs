using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_ASSIGNMENT4_abstract__partial__interface
{
    
    public interface IDrive
    {
        
        void Drive();
    }

    public class Car2 : IDrive
    {
        public string Name = "Anwar";
        public void Drive()
        {
            Console.WriteLine($"{Name} is driving the car");
        }
    }
    public class Truck : IDrive
    {
        public string name = "Zaman";
        public void Drive()
        {
            Console.WriteLine($"{name} is driving the Truck");
        }
    }
}
