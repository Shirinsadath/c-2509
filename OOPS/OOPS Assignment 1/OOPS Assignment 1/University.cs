using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment_1
{
    public class University
    {
        public class Course
        {
            public string CourseName { get; set; }
            public string CourseCode { get; set; }
            public int Credits { get; set; }

            public Course(string courseName, string courseCode, int credits)
            {
                CourseName = courseName;
                CourseCode = courseCode;
                Credits = credits;
            }

            public override string ToString()
            {
                return $"Course Name: {CourseName}, Course Code: {CourseCode}, Credits: {Credits}\n";
            }
        }

        public class Department
        {
            public string Name { get; set; }
            public List<Course> Courses { get; set; }

            public Department(string name)
            {
                Name = name;
                Courses = new List<Course>();
            }

            public void AddCourse(string courseName, string courseCode, int credits)
            {
                Courses.Add(new Course(courseName, courseCode, credits));
            }
        }

        private List<Department> departments = new List<Department>();

        public void AddDepartment(string name)
        {
            departments.Add(new Department(name));
            Console.WriteLine($"Department {name} added\n");
        }

        public void AddCourseToDepartment(string departmentName, string courseName, string courseCode, int credits)
        {
            Department department = departments.Find(d => d.Name == departmentName);
            if (department != null)
            {
                department.AddCourse(courseName, courseCode, credits);
                Console.WriteLine($"Course {courseName} added to department {departmentName}\n");
            }
            else
            {
                Console.WriteLine($"Department {departmentName} not found\n");
            }
        }

        public void DisplayCourseDetails()
        {
            foreach (var department in departments)
            {
                Console.WriteLine($"Department: {department.Name} \n");
                foreach (var course in department.Courses)
                {
                    Console.WriteLine(course);
                }
            }
        }
    }

    }
