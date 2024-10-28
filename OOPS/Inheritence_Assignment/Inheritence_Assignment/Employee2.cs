using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Person constructor called: {Name}, {Age} years old");
        }
    }

    public class Employee2 : Person
    {
        public int EmployeeId { get; set; }

       
        public Employee2(string name, int age, int employeeId) : base(name, age)
        {
            EmployeeId = employeeId;
            Console.WriteLine($"Employee constructor called: Employee ID {EmployeeId}");
        }

    }
}
