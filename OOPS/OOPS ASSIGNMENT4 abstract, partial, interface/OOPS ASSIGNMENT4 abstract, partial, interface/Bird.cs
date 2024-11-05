using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_ASSIGNMENT4_abstract__partial__interface
{
    abstract class Bird
    {
        public abstract void Fly();
        
    }
    public interface Iswim
    {
        void Swim();

    }
    class Eagle : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Eagle is flying high");
        }
    }
    class Penguin : Bird, Iswim
    {
        public override void Fly()
        {
            Console.WriteLine("Penguin is flightless bird");
        }
        public void Swim()
        {
            Console.WriteLine("Penguins can swim");
        }
    }
}
