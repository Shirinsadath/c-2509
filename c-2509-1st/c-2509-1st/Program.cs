using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_2509_1st
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LAB 1

            //Console.WriteLine("HELLO WORLD");
            //Console.WriteLine("Enter your name : ");
            //string name = Console.ReadLine();
            //Console.WriteLine(" Hello " + name +  " Welcome to the day 1 assignment");
            //Console.ReadLine() ;

            //LAB 2 

            //Console.WriteLine("enter the full name ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter the age ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your Favorite color");
            //string color = Console.ReadLine();
            //Console.WriteLine($"Hello {name}! You are {age} years old, Your favorite color is {color}");
            ////Console.WriteLine("Hello " + name + "! You are " + age + " years old. Your favorite color is " + color);
            //Console.ReadLine();


            //LAB 3
            //Console.WriteLine("enter the value : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //int div = 0;

            //if (a > b && b!=0)
            //{
            //    div = a / b;
            //    Console.WriteLine($"Division = {div}");
            //}
            //else if (b > a && a!=0)
            //{
            //    div = b / a;
            //    Console.WriteLine($"Division = {div}");


            //}
            //else 
            //{
            //    Console.WriteLine("Division not possible");


            //}
            //Console.WriteLine($"sum = {a + b} difference ={a - b} multiplication = {a * b}");

            //Console.ReadLine();


            ////LAB 4
            //Console.WriteLine("Enter the temperature in celsius : ");
            //double temp = Convert.ToDouble(Console.ReadLine());
            //double far = 0;
            //far = (temp * 1.8) + 32;
            //Console.WriteLine($"temp in farenheit is {far}");
            //Console.ReadLine();


            //LAB 5
            //Console.WriteLine("enter the AMOUNT");
            //int PrincipalAmount = Convert.ToInt32((Console.ReadLine()));
            //Console.WriteLine("enter the ROI");
            //double RateofInterest = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the TIME");
            //int Time = Convert.ToInt32((Console.ReadLine()));
            //double SimpleInterest;
            //SimpleInterest = (PrincipalAmount * RateofInterest * Time) / 100;
            //Console.WriteLine($" Simple interest is {SimpleInterest}");
            //Console.ReadLine();

            //LAB 6
            //Console.WriteLine("ENTER THE RADIUS ");
            //Double Radius = Convert.ToDouble(Console.ReadLine());
            //Double Area;
            //const double Pi = 3.14;
            //Area = Pi * Radius * Radius;
            //Console.WriteLine($"The area is {Area}");
            //Console.ReadLine();

            //LAB 7
            //Console.WriteLine("Enter the Seconds");
            //int TotalSeconds = Convert.ToInt32(Console.ReadLine());
            //int Hours;
            //int Minutes;
            //int Seconds;
            //Hours = TotalSeconds / 3600;
            //Minutes = (TotalSeconds % 3600) / 60;
            //Seconds = (TotalSeconds % 60);
            //Console.WriteLine($"Converted time is {Hours} hour {Minutes} minute {Seconds} Seconds");
            //Console.ReadLine();

            //LAB 8
            //Console.WriteLine("Enter a sentence : ");
            //string Sentence = Console.ReadLine();
            //string SpaceExcludedString = Sentence.Replace(" ", "");
            //int Length = SpaceExcludedString.Length;
            //Console.WriteLine("the output is : " + SpaceExcludedString + " and the length is : " + Length);
            //Console.ReadLine();

            //LAB9
            //Console.WriteLine("Enter the Weight");
            //Double Weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the height ");
            //Double Height = Convert.ToDouble(Console.ReadLine());
            //Double BodyMassIndex = Weight / (Height * Height);
            //Console.WriteLine("The body mass index is " + BodyMassIndex);
            //Console.ReadLine();

            //LAB10

            //int Integer = 30;
            //Double Doublev = 2.6;
            //char Character = 'a';
            //string String = "hello";
            //bool Boolean = true;
            //float value = 3.14565555255f;
            //Console.WriteLine($"{Integer} is a {Integer.GetTypeCode()}");

            //Console.WriteLine($"{Doublev} is a {Doublev.GetTypeCode()}");
            //Console.WriteLine($"{Character} is a {Character.GetTypeCode()}");
            //Console.WriteLine($"{String} is a {String.GetTypeCode()}");
            //Console.WriteLine($"{Boolean} is a {Boolean.GetTypeCode()}");
            //Console.WriteLine($"{value} is a float type ");
            //Console.ReadLine();

            //LAB11
            //Console.WriteLine("Enter the Radius : ");
            //Double Radius = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the length :");
            //int Length = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the breadth :");
            //int Breadth = Convert.ToInt32(Console.ReadLine());
            //const double pi = 3.14;
            //Double AreaofCircle;
            //Double AreaofRectangle;
            //AreaofCircle = pi * Radius * Radius;
            //AreaofRectangle = Length * Breadth;
            //Console.WriteLine($" Area of circle is {AreaofCircle} and area of rectangle is {AreaofRectangle}");
            //Console.ReadLine();


            //lab12
            //const Double PI= 3.14159;
            //const int DAYS_IN_A_WEEK = 7;
            //Console.WriteLine("Enter the radius : ");
            //int Radius = Convert.ToInt32(Console.ReadLine());
            //Double Circumference = 2 *  PI * Radius;
            //Console.WriteLine("Circumference of teh circle is " + Circumference + " and days in a week is " + DAYS_IN_A_WEEK);
            //Console.ReadLine();

            //LAB13
            //Console.WriteLine("Enter the width in cm");
            //Double Width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the height in cm");
            //Double Height = Convert.ToDouble(Console.ReadLine());
            //const Double Inches = 0.3937;
            //Double Area = Width * Height;
            //Double AreainInches = Area * Inches;
            //Console.WriteLine($"Area of rectangle in inches {AreainInches} and in centimeter {Area}");
            //Console.ReadLine();

            //LAB14
            //Console.WriteLine("Enter the Employee name : ");
            ////input the employee name
            //string EmployeeName = Console.ReadLine();
            //Console.WriteLine("Enter the employee age : ");
            /////input the age
            //int EmployeeAge = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Employee Salary : ");
            ////input the salary
            //int EmployeeSalary = Convert.ToInt32(Console.ReadLine());
            ////Printing the input in as single sentence 
            //Console.WriteLine($"{EmployeeName} is the name of Employee, {EmployeeAge} years old , with a salary of {EmployeeSalary} per month ");
            //Console.ReadLine();


            //LAB15
            ////INPUT NUMBER1
            //int Number1 = 5;
            ////INPUT NUMBER2
            //int Number2 = 3;
            ////ADDING THE NUMBERS AND PRINTING IT
            //Console.WriteLine(Number1 + Number2);
            //Console.ReadLine();

            //LAB16
            //int Number = 10;
            //Console.WriteLine($"{Number} is the initial value ");
            //Number += 20;
            //Console.WriteLine($"{Number} is the added  value ");
            //Number -= 15;
            //Console.WriteLine($"{Number} is the substracted value ");
            //Console.ReadLine();

            //LAB17

            //Console.WriteLine("Enter the base value ");
            //Double Base_Value = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the exponent value ");
            //Double Exponent_Value = Convert.ToDouble(Console.ReadLine());
            //Double Power_of_number = Math.Pow(Base_Value, Exponent_Value);
            //Console.WriteLine($"The output of the {Base_Value} to the power of {Exponent_Value} is {Power_of_number}");
            //Console.ReadLine();

            //LAB18

            //Console.WriteLine("Enter the name of the candidate : ");
            //string Name_of_Candidate = Console.ReadLine();
            //Console.WriteLine("Enter the Nationality of the candidate : Indian / other");
            //String Nationality = Console.ReadLine();
            //const string indian = "indian";
            //const string Indian = "Indian";
            //const string INDIAN = "INDIAN";
            //if (Nationality == Indian || Nationality == indian || Nationality == INDIAN)
            //{
            //    Console.WriteLine("Continue to enter the age ");
            //    Console.WriteLine("Enter the age of the candidate : ");
            //    int Age = Convert.ToInt32(Console.ReadLine());
            //    if (Age >= 18)
            //    {
            //        Console.WriteLine($"{Name_of_Candidate} is eligible of voting");
            //        ;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{Name_of_Candidate}  is not eligilble for voting");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{Name_of_Candidate} is not eligible for voting ");

            //}
            //Console.ReadLine();


            //LAB19

            //Console.WriteLine("Enter the name of the applicant : ");
            //string Name_of_Applicant = Console.ReadLine();
            //Console.WriteLine("Enter the age of the applicant : ");
            //int Age_of_Applicant =Convert.ToInt32(Console.ReadLine());
            //if (Age_of_Applicant >= 21)
            //{
            //    Console.WriteLine("Enter the Annual Salary of the applicant : ");
            //    int Annual_Salary_of_Applicant = Convert.ToInt32(Console.ReadLine());
            //    if (Annual_Salary_of_Applicant >= 30000)
            //    {
            //        Console.WriteLine("Any outstanding loan (Y / N) : ");
            //        char Pending_Loan = Convert.ToChar(Console.ReadLine());
            //        if ((Pending_Loan == 'n') || (Pending_Loan == 'N'))
            //        {
            //            Console.WriteLine($"{Name_of_Applicant} is eligible for the applied loan ");

            //        }
            //        else
            //        {
            //            Console.WriteLine($"{Name_of_Applicant} is not eligible for the applied loan");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{Name_of_Applicant} is not eligible for the applied loan");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{Name_of_Applicant} is not eligible for the applied loan");
            //}
            //Console.ReadLine();


            //LAB20

            //Console.WriteLine("Enter the name of the applicant : ");
            //string Name_of_Applicant = Console.ReadLine();
            //Console.WriteLine("Enter the age of the applicant : ");
            //int Age_of_Applicant = Convert.ToInt32(Console.ReadLine());
            //if (Age_of_Applicant >= 18 && Age_of_Applicant <= 35)
            //{
            //    Console.WriteLine("Enter the Work Experience :");
            //    int Work_Experience = Convert.ToInt32(Console.ReadLine());
            //    //Console.WriteLine("Do you have a college degree (Y/N)");
            //    //Char College_Degree = Convert.ToChar(Console.ReadLine());
            //    if (Work_Experience >= 2)
            //    {
            //        Console.WriteLine("Do you have a college degree (Y/N)");
            //        Char College_Degree = Convert.ToChar(Console.ReadLine());
            //        if (College_Degree == 'y' || College_Degree == 'Y' || Work_Experience >= 5)
            //        {
            //            Console.WriteLine($"{Name_of_Applicant} is eligible to apply for the job");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{Name_of_Applicant} is not eligible to apply for the job");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{Name_of_Applicant} is not eligible to apply for the job");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{Name_of_Applicant} is not eligible to apply for the job ");
            //}
            //Console.ReadLine();


            //LAB21
            //Console.WriteLine("enter the character to be checked :");
            //char Character_to_Checked = Convert.ToChar(Console.ReadLine());
            //if (Character_to_Checked == 'a' || Character_to_Checked == 'e' || Character_to_Checked == 'i' || Character_to_Checked == 'o' || Character_to_Checked == 'u' || Character_to_Checked == 'A' || Character_to_Checked == 'E' || Character_to_Checked == 'I' || Character_to_Checked == 'O' || Character_to_Checked == 'U')
            //{
            //    Console.WriteLine($"{Character_to_Checked} is a vowel");
            //}
            //else
            //{
            //    Console.WriteLine($"{Character_to_Checked} is a consonant");
            //}
            //Console.ReadLine();


            //LAB22

            //Console.WriteLine("Enter the number to be checked : ");
            //int Number_tobe_Checked = Convert.ToInt32(Console.ReadLine());  
            //if(Number_tobe_Checked < 0)
            //{
            //    Console.WriteLine($"{Number_tobe_Checked} is a negative number");
            //}
            //else if (Number_tobe_Checked > 0)
            //{
            //    Console.WriteLine($"{Number_tobe_Checked} is a positive number");

            //}
            //else
            //{
            //    Console.WriteLine($"{Number_tobe_Checked} is zero");
            //}
            //Console.ReadLine();

            //LAB23


            //Console.WriteLine("Enter the number to be checked : ");
            //int Number_tobe_Checked = Convert.ToInt32(Console.ReadLine());
            //if ((Number_tobe_Checked % 5 == 0) && (Number_tobe_Checked % 11 == 0))
            //{
            //    Console.WriteLine($"{Number_tobe_Checked} is divisible by both 5 and 11 ");
            //}
            //else {
            //    Console.WriteLine($"{Number_tobe_Checked} is not divisible by both 5 and 11 ");
            //}
            //Console.ReadLine();


            //LAB24
            //Console.WriteLine("enter the first number");
            //int First_Number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the second number");
            //int Second_Number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter operation to used (+ - * / ) : ");
            //char Operator = Convert.ToChar(Console.ReadLine());
            //if (Operator == '+')
            //{
            //    Console.WriteLine($"The output for the addition is {First_Number + Second_Number}");
            //}
            //else if (Operator == '-')
            //{
            //    Console.WriteLine($"The output for the substraction is {First_Number - Second_Number}");
            //}
            //else if (Operator == '*')
            //{
            //    Console.WriteLine($"The output for the multiplication is {First_Number * Second_Number}");
            //}
            //else if (Operator == '/')
            //{
            //    if (Second_Number == 0)
            //    {
            //        Console.WriteLine("Division not possible");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The output for the division is {First_Number / Second_Number}");
            //    }
            //}
            //Console.ReadLine();

            //LAB25
            //Console.WriteLine("Enter the Name of the student ");
            //string Name_of_Student = Console.ReadLine();
            //Console.WriteLine("Enter the marks out od 100");
            //int Total_Marks = Convert.ToInt32(Console.ReadLine());
            //if (Total_Marks >= 90)
            //{
            //    Console.WriteLine($"The grade of {Name_of_Student} is A ");
            //}
            //else if (Total_Marks >= 80 && Total_Marks <= 89)
            //{
            //    Console.WriteLine($"The grade of {Name_of_Student} is  B");
            //}
            //else if (Total_Marks >= 70 && Total_Marks <= 79)
            //{
            //    Console.WriteLine($"The grade of {Name_of_Student} is  C");
            //}
            //else if (Total_Marks >= 60 && Total_Marks <= 69)
            //{
            //    Console.WriteLine($"The grade of {Name_of_Student} is  D");
            //}
            //else if ( Total_Marks < 69)
            //{
            //    Console.WriteLine($"The grade of {Name_of_Student} is  F");
            //}
            //Console.ReadLine();


            //LAB26
            //Console.WriteLine("Enter the first value");
            //int First_Value = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second value");
            //int Second_Value = Convert.ToInt32(Console.ReadLine());
            //int Swap_Variable = First_Value;
            //First_Value = Second_Value;
            //Second_Value = Swap_Variable;
            //Console.WriteLine($"after swapping the value first value = {First_Value} Second = {Second_Value}"); 
            //Console.ReadLine();
            ////without third variable
            //Console.WriteLine("Enter the first value");
            //int First_Value_1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second value");
            //int Second_Value_1 = Convert.ToInt32(Console.ReadLine());
            //First_Value_1  = First_Value_1 + Second_Value_1;
            //Second_Value_1 = First_Value_1 - Second_Value_1;
            //First_Value_1 = First_Value_1 - Second_Value_1;
            //Console.WriteLine("swapping without a third variable");
            //Console.WriteLine($"The values after the swap is First value = {First_Value_1} and the second value = {Second_Value_1}");
            //Console.ReadLine();


            //LAB27
            //Console.WriteLine("Enter the first value");
            //int First_Value = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second value");
            //int Second_Value = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Output after addition {First_Value + Second_Value}");
            //Console.WriteLine($"Output after substraction {First_Value - Second_Value}");
            //Console.WriteLine($"Output after multiplication {First_Value * Second_Value}");
            //Console.WriteLine($"Output after modulus {First_Value % Second_Value}");
            //Console.WriteLine($"output of incrementing {First_Value++} and {Second_Value++}");
            //Console.WriteLine($"output of incrementing {First_Value--} and {Second_Value--}");
            //if (Second_Value == 0)
            //{
            //    Console.WriteLine("Inavild input");
            //}
            //else
            //{
            //    Console.WriteLine($"Output after divison {First_Value / Second_Value}");
            //}
            //Console.ReadLine();








            //LAB28

            //Console.WriteLine("Enter the first value");
            //Double First_Value = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the second value");
            //Double Second_Value = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the third value");
            //Double Third_Value = Convert.ToDouble(Console.ReadLine());
            //Double Average;
            //Average = (First_Value + Second_Value + Third_Value) / 3;
            //Console.WriteLine("The average of the numbers are {0:F2}" , Average);
            //Console.ReadLine();


            //lab29
            //Console.WriteLine("Enter the amount to be converted");
            //Double Amount_in_USD = Convert.ToDouble(Console.ReadLine());
            //Double Amount_in_EUR = Amount_in_USD * 0.85;
            //Console.WriteLine($"The amount {Amount_in_USD} converted in euros is {Amount_in_EUR} ");
            //Console.ReadLine();


            //LAB30
            //Console.WriteLine("Enter the value");
            //Double First_Value = Convert.ToDouble(Console.ReadLine());
            //if (First_Value <= 100 && First_Value >= 1)
            //{
            //    Console.WriteLine($"{First_Value}is in between 1 and 100 now check whether even or odd");
            //    if (First_Value % 2 == 0)
            //    {
            //        Console.WriteLine($"{First_Value} is even ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{First_Value} is odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{First_Value} is not in between 1 and 100");
            //}
            //Console.ReadLine();


            //LAB31
            //Console.WriteLine("Enter the value");
            //Double First_Value = Convert.ToDouble(Console.ReadLine());
            //if (First_Value % 3 == 0 && First_Value % 5 == 0)
            //{
            //    Console.WriteLine($"{First_Value} is divisible by both 3 and 5");
            //}
            //else
            //{
            //    Console.WriteLine($"{First_Value} is not divisible by both 3 and 5");
            //}
            //Console.ReadLine();



            //LAB32
            //Console.WriteLine("Enter the year");
            //int year = Convert.ToInt32(Console.ReadLine());
            //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //{
            //    Console.WriteLine($"{year} is a leap year");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} is not  leap year");
            //}
            //Console.ReadLine();

            //LAB33
            //Console.WriteLine("Enter the value");
            //Double First_Value = Convert.ToDouble(Console.ReadLine());
            //if (First_Value > 0)
            //{
            //    if (First_Value % 2 == 0)
            //    {
            //        if (First_Value > 50)
            //        {
            //            Console.WriteLine($"{First_Value} is positive , even and greater than 50");

            //        }
            //        else
            //        {
            //            Console.WriteLine($"{First_Value} is only positive and even");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{First_Value} is only positive ");
            //    }


            //}
            //else
            //{
            //    Console.WriteLine($"{First_Value}   is not positive , even and greater than 50 ");
            //}


            //Console.ReadLine();



            //LAB34
            Console.WriteLine("Enter the name of the student");
            string Name = Console.ReadLine();
            Console.WriteLine("enter the marks of 1st subject");
            int First_Subject = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks of Second subject");
            int Second_Subject = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks of Third subject");
            int Third_Subject = Convert.ToInt32(Console.ReadLine());
            int Failed_Subject = 0;
            int Average = (First_Subject + Second_Subject + Third_Subject) / 3;
            if (First_Subject >= 40 && Second_Subject >= 40 && Third_Subject >= 40)
            {
                if (Average >= 70)
                {
                    Console.WriteLine($"{Name} has distinction");
                }
                else
                {
                    Console.WriteLine($"{Name} has PASSED");
                }
            }
            else
            {
                if (First_Subject < 40)
                {
                    Failed_Subject += 1;
                }
                else if (Second_Subject < 40)
                {
                    Failed_Subject += 1;
                }
                else if (Third_Subject < 40)
                {
                    Failed_Subject += 1;
                }
                Console.WriteLine($"{Name} has failed in {Failed_Subject} subjects");
            }

            Console.ReadLine();


            //LAB35
            //Console.WriteLine("Enter the name");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Enter the annual salary");
            //int Annual_Salary = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the age");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //int Tax = 0;
            //if (Annual_Salary <= 10000)
            //{
            //    Console.WriteLine($"{Name} has 0 Tax applied");
            //}
            //else if (Annual_Salary > 10000 && Annual_Salary <= 50000)
            //{
            //    Tax += (10/100) * Annual_Salary;
            //    if (Age>= 60)
            //    {
            //        Tax = Tax - 5000;
            //    }
            //    else
            //    {
            //        Tax = Tax;
            //    }

            //    Console.WriteLine($"{Name} has tax to be paid as {Tax}");

            //}
            //else if (Annual_Salary > 50000)
            //{
            //    Tax  += (20 / 100) * Annual_Salary;
            //    if (Age >= 60)
            //    {
            //        Tax = Tax - 5000;
            //    }
            //    else
            //    {
            //        Tax = Tax;
            //    }

            //    Console.WriteLine($"{Name} has tax to be paid as {Tax}");

            //}

            //Console.ReadLine();
        }
    }
}
