using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment_1
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Student(string name, int id)
        {
            Name = name;
            ID = id;
        }
        public List<double> Grades { get; set; } = new List<double>();
        public void AddGrade(double grade)
        {
            Grades.Add(grade);
            Console.WriteLine($"Grade {grade} added");
        }
        public double AverageGrade()
        {
            double Total = 0;
            foreach (double grade in Grades)
            {
                Total += grade;
            }
            return Total / Grades.Count;

        }
    }
}
