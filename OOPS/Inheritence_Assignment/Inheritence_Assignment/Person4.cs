using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment
{
    public class Person4
    {
        public string Name { get; set; }
    }
    class Student : Person4
    {
        public new string Name { get; set; }

        public void ShowNames()
        {
            Console.WriteLine($"Base class Name: {base.Name}");
            Console.WriteLine($"Derived class Name: {this.Name}");
        }
    }

}
