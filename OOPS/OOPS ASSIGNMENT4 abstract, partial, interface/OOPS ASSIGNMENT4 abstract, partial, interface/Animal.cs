using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_ASSIGNMENT4_abstract__partial__interface
{
    public class Animal
    {
        //Virtual method MakeSound
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal is making the sound");
        }

    }
    //Derived class
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The Dog is creating noice by barking...");
        }
    }
    public class Cat :Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat is creating noice by meowing...");
        }
    }
}
