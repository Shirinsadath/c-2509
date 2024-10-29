using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //Interface 
    interface IMovable
    {
        void Move();
    }
    //Interface
    interface IDrawable
    {
        void Draw();
    }
    //Multiple inheritence
    class Car2 : IMovable, IDrawable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving");
        }

        public void Draw()
        {
            Console.WriteLine("\nDrawing the car");
        }
    }
    
}
