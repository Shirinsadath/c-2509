using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_ASSIGNMENT4_abstract__partial__interface
{
    public partial class Employee
    {
        public string FullName { get; set; }
        public string Department { get; set; }
        public int DaysWorked { get; set; }
        public int DailyWage {  get; set; }

        partial void CalculateSalary();
    }
    public partial class Employee
    {
        partial void CalculateSalary()
        {
            int Salary = DaysWorked * DailyWage;
            Console.WriteLine($"Salary of {FullName} : {Salary} ");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Full Name : {FullName} \nDepartment : {Department} \n" +
                $"Days Worked : {DaysWorked} \nDaily Wage : {DailyWage}");
            CalculateSalary();
        }
    }
}
