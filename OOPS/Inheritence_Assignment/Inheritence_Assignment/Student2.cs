using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Assignment
{
    public class Student2
    {
        public string StudentName { get; set; }
        public int StudentId { get; set; }
        public Student2(string studentName, int studentId)
        {
            StudentName = studentName;
            StudentId = studentId;
            Console.WriteLine(studentName + studentId);
        }
    }
    public class Volunteer : Student2
    {
        public int VolunteerId { get; set; }
        public Volunteer(string studentName, int studentId, int volunteerId) : base(studentName, studentId)
        {
            VolunteerId = volunteerId;
            Console.WriteLine($"{studentName} {studentId} with {volunteerId}");

        }



    }

}
