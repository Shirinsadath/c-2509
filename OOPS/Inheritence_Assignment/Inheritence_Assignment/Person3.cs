using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment
{
    class Person3
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Displaying Person Information");
        }
    }

    class Employee3 : Person3
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Displaying Employee Information");
            base.DisplayInfo(); 
        }
    }

}
