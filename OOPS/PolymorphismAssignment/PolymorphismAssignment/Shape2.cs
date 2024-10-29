using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    using System; 
    // Interface IShape
    interface IShape
    {
        void Draw();
    }
    // Abstract class Shape
    abstract class Shape2 : IShape

    {
        // Abstract method
        public abstract void Draw();
    }
    // Derived class Circle
     class Circle2 : Shape2
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
    // Derived class Rectangle
    class Rectangle2 : Shape2
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}
