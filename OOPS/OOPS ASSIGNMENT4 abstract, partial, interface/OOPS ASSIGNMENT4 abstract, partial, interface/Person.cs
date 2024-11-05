using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_ASSIGNMENT4_abstract__partial__interface
{
    public partial class Person
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public int Age { get; set; }
    }
    public partial class Person
    {
        public void ShowDetails()
        {
            Console.WriteLine($"Name : {FirstName} {LastName} , Age : {Age}");
        }
    }
}
