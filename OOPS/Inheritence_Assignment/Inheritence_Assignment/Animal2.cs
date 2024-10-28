using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment
{
    public class Animal2
    {
        public string Name { get; set; }
        public Animal2(string Name) 
        {
            this.Name = Name;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is the animal");
        }
    }
    public class Dog2 : Animal2
    {
        public Dog2(string Name):base(Name)
        {

        }
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking...");
        }
    }
}
