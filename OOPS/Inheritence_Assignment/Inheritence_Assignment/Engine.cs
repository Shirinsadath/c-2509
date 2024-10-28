using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment
{
    class Engine
    {
        public int HorsePower { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Engine HorsePower: {HorsePower}");
        }
    }

    class Car2
    {
        public Engine Engine { get; set; }

        public void ShowEngineDetails()
        {
            Engine.ShowDetails();
        }
    }
}
