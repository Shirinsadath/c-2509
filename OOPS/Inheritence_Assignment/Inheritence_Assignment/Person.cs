//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Inheritence_Assignment
//{
//    public class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public Person(string Name,int Age) 
//        {
//            this.Name = Name;
//            this.Age = Age;
//            Console.WriteLine("\n");
//            Console.WriteLine($"{Name} is {Age} years old");

//        }
//    }
//    public class Student : Person
//    {
//        public string Grade;
        
//        public Student(string Name , int Age ,string Grade):base(Name,Age)
//        {
            
//            this .Grade = Grade;
//            Console.WriteLine($"He/She has {Grade} grade\n");
//        }
//    }
//}
