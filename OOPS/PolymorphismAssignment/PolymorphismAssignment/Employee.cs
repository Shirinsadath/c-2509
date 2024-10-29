using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee
    {
        public string Name { get; set; }
        public string[] Task {  get; set; }
        public Employee(string name,string[] task)
        {
            Name = name;
            Task = task;
        }
        public virtual void DisplayDetails()
        {
            Console.Write($"{Name} task : ");
            foreach (var task in Task)
            {  
                Console.WriteLine($" {task}"); 
            }
                
        }

    }
    public class Manager : Employee
    {
        public Manager(string name, string[] task) : base(name, task)
        {

        }
        public override void DisplayDetails()
        {
            Console.Write($"Manager : {Name} , Task : ");
            foreach (var task in Task)
            {
                Console.WriteLine($" {task}");
            }

        }
        public class Developer : Employee
        {
            public Developer(string name, string[] task) : base(name, task) { }
            public override void DisplayDetails()
            {
                Console.Write($"Developer : {Name}, task : ");
                foreach (var task in Task)
                {
                    Console.WriteLine($" {task}");
                }
            }
        }
    }

}
