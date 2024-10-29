using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    abstract class Product
    {
        public readonly string Name;
        public Product(string name)
        {
            Name = name;
        }
        public abstract void DisplayDetails();
    }
    class Electronics : Product 
    {
        public Electronics(string name) : base(name) 
        { }
        public override void DisplayDetails()
        { 
            Console.WriteLine($"Electronics Product: {Name}");
        }
    }
    class Groceries : Product
    {
        public Groceries(string name) : base(name)
        { }
        public override void DisplayDetails() 
        {
            Console.WriteLine($"Groceries Product: {Name}");
        }
    }
}
