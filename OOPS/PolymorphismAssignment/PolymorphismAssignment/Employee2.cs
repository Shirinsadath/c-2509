using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Employee2
    {
        public string Name { get; set; }
        public static int EmployeeCount { get; private set; }

        public Employee2(string name)
        {
            Name = name;
            EmployeeCount++;
        }

        public static void DisplayEmployeeCount()
        {
            Console.WriteLine($"Total Employees: {EmployeeCount}");
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }

    class Manager2 : Employee2
    {
        public Manager2(string name) : base(name) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
    }
    class Developer2 : Employee2
    {
        public Developer2(string name) : base(name) { }
        public override void Work()
        {
            Console.WriteLine($"{Name} is writing code.");
        }
    }
}
