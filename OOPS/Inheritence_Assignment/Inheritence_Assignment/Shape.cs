using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("A circle is drawn");
        }
        
    }
    public class Rectange : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("A rectangle is drawn");
        }
    }
}
