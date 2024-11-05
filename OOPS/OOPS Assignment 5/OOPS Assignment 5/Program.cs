using static System.Formats.Asn1.AsnWriter;
using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System;
using OOPS_Assignment_5;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.ComponentModel;
using System.IO;
using static System.Reflection.Metadata.BlobBuilder;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //Assignment 1. Identify the need for single and multidimensional arrays as 
        //    properties of a class
        //Question : Create a Library class to store and manage books in a single-dimensional array where
        //    each element represents a book title.Also, use a two-dimensional array in a Classroom class
        //    where each element represents the seat of a student based on rows and columns.

        //// Library Example 
        //Library library = new Library(); 
        //library.DisplayBooks(); 
        //// Classroom Example
        //Classroom classroom = new Classroom();
        //classroom.DisplaySeats();

        //========================================================================================================================================================================================================================

        //        Assignment 2.Identify the need for an array of objects
        //Question: Define a Movie class with properties like Title and Year.Create a MovieLibrary class
        //that stores an array of Movie objects and displays each movie’s information.

        //MovieLibrary library = new MovieLibrary();
        //library.Display();
        //Console.ReadLine();

        //======================================================================================================================================================================================================

        //Assignment 3. Identify the need for enumerations 
        //Question: Create an enumeration OrderStatus with values Pending, Shipped, and Delivered. 
        //Define an Order class with an OrderStatus property to manage the status of each order.

        //Order order = new Order 
        //{
        //    OrderId = 216,
        //    Status = OrderStatus.pending
        //};
        //Order order1 = new Order()
        //{
        //    OrderId = 217,
        //    Status = OrderStatus.pending
        //};


        //Console.WriteLine($"Order ID: {order.OrderId}, Status: {order.Status}"); 
        //// Update the order status
        //order.Status = OrderStatus.shipped;
        //Console.WriteLine($"Order ID: {order.OrderId}, Status: {order.Status}");
        //order.Status = OrderStatus.delivered;
        //Console.WriteLine($"Order ID: {order.OrderId}, Status: {order.Status}\n");
        //Console.WriteLine($"Order ID: {order1.OrderId}, Status: {order1.Status}");
        //order1.Status = OrderStatus.shipped;
        //Console.WriteLine($"Order ID: {order1.OrderId}, Status: {order1.Status}");
        //order1.Status = OrderStatus.delivered;
        //Console.WriteLine($"Order ID: {order1.OrderId}, Status: {order1.Status}");
        //Console.ReadLine();

        //================================================================================================================================================================================================

        //        Assignment 4.Identify the need for value types and reference types
        //Question: Create a Circle struct to represent a circle as a value type, and a Shape class to
        //represent a reference type.Show how changing values affects each.

        // Working with the Circle struct (value type)
        //Circle circle1 = new Circle 
        //{
        //    Radius = 5.0 
        //};
        //Circle circle2 = circle1;
        //circle2.Radius = 10.0;

        //Console.WriteLine($"Circle1 Radius: {circle1.Radius}"); 
        //Console.WriteLine($"Circle2 Radius: {circle2.Radius}");

        //circle1.Display();
        //circle2.Display();
        //// Working with the Shape class (reference type)
        //Shape shape1 = new Shape 
        //{
        //    Size = 5.0
        //}; 
        //Shape shape2 = shape1;
        //shape2.Size = 10.0;
        //Console.WriteLine($"Shape1 Size: {shape1.Size}"); 
        //Console.WriteLine($"Shape2 Size: {shape2.Size}");
        //Console.ReadLine();

        //=========================================================================================================================================================================================================================

        //        Assignment 5.Identify the need for pass by reference using ref keyword
        //Question: Create a method IncreaseScore that takes a ref integer parameter representing a
        //player’s score and increases it by 10.

        //    int playerScore = 50;
        //    Console.WriteLine($"Initial Score: {playerScore}");
        //    IncreaseScore(ref playerScore); 
        //    Console.WriteLine($"Updated Score: {playerScore}");
        //}
        //static void IncreaseScore(ref int score) 
        //{
        //    score += 10;
        //}
        //===================================================================================================================================================================================================

        //        Assignment 6.Identify the need for out parameters
        //Question: Create a method Divide that takes two integers, calculates their quotient and
        //remainder, and returns both values using the out keyword.

        //    int number1 = 97;
        //    int number2 = 8;
        //    int quotient, remainder;
        //    Divide(number1, number2, out quotient, out remainder);
        //    Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
        //}
        //static void Divide(int number1, int number2, out int quotient, out int remainder)
        //{
        //    quotient = number1 / number2;
        //    remainder = number1 % number2;
        //}

        //===========================================================================================================================================================================================

        //Assignment 7.What is Exception and its Types
        //Question: Write a C# program that demonstrates a FileNotFoundException and an 
        //IndexOutOfRangeException. Explain what causes these exceptions.

        ////INCOMPLETE---------------------------------------------------------------------

        // Demonstrating FileNotFoundException
        try
        {
            string filePath = "nonexistentfile.txt"; 
            string content = File.ReadAllText(filePath); 
            Console.WriteLine(content); 
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"FileNotFoundException: {ex.Message}"); 
        }
        // Demonstrating IndexOutOfRangeException
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]); 
            // This will throw an IndexOutOfRangeException
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"IndexOutOfRangeException: {ex.Message}"); 
        }


        //==============================================================================================================================================================
        //        Assignment 8.How to Handle Exception
        //Question: Create a method GetUserInput that prompts the user to enter an integer. If the input is
        //invalid, catch the exception and prompt the user again until they enter a valid integer.

        //    int userInput = GetUserInput(); 
        //    Console.WriteLine($"You entered: {userInput}");
        //    Console.ReadLine();
        //}
        //static int GetUserInput()
        //{
        //    int result;
        //    while (true)
        //    {
        //        Console.WriteLine("Please enter an integer:"); try
        //        {
        //            result = int.Parse(Console.ReadLine());
        //            return result; 

        //        } 
        //        catch 
        //        (FormatException)
        //        {
        //            Console.WriteLine("Invalid input. That's not an integer. Try again."); 
        //        }
        //    }
        //}

        //===========================================================================================================================================================================

        //        Assignment 9.Multiple Catch Blocks
        //Question: Create a method that calculates the division of two integers. Use multiple catch blocks
        //to handle DivideByZeroException and FormatException. 

        //    Console.WriteLine("Enter the dividend : ");
        //    int number1 = GetUserInput();
        //    Console.WriteLine("Enter the divisor : ");
        //    int number2 = GetUserInput();
        //    try
        //    {
        //        int Result = number1 / number2;
        //        Console.WriteLine($"Result : {Result}");
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        Console.WriteLine($"Error : {ex.Message}");
        //    }
        //    catch (FormatException ex)
        //    {
        //        Console.WriteLine($"Error : {ex.Message}");
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Succesfully Executed");
        //    }
        //    Console.ReadLine();


        //}
        //static int GetUserInput() 
        //{
        //    while (true) 
        //    {

        //        try
        //        {
        //            return int.Parse(Console.ReadLine());
        //        }
        //        catch (FormatException) 
        //        {
        //            Console.WriteLine("Invalid input. Please enter a valid integer.");
        //        }
        //    }
        //}

        //====================================================================================================================================================================================================================
        //Assignment 10. Finally Block 
        //    Question: Write a method ReadFile that opens a file, reads its contents, and closes it. Use a 
        //finally block to ensure the file is closed, even if an exception occurs.

        //DOUBT----------------------------------------------------

        //    string filePath = "example.txt"; 
        //    ReadFile(filePath);
        //}
        //static void ReadFile(string filePath)
        //{
        //    StreamReader reader = null; 
        //    try
        //    {
        //        reader = new StreamReader(filePath);
        //        string content = reader.ReadToEnd();
        //        Console.WriteLine("File content:");
        //        Console.WriteLine(content);
        //    } 
        //    catch (FileNotFoundException ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        //    }
        //    finally 
        //    {
        //        if (reader != null)
        //        {
        //            reader.Close(); 
        //            Console.WriteLine("File closed.");
        //        }
        //    }
        //}

        //==========================================================================================================================================================================================================
        //        Assignment 11.Difference between throw and throws
        //Question: Explain the purpose of the throw keyword in C#. Create a method ValidateAge that 
        //throws an exception if the age is below 18, and handle it in the calling method.
        //    Console.WriteLine("Enter the age :");
        //    int age =Convert.ToInt32(Console.ReadLine());   
        //    try
        //    {
        //        ValidateAge(age);

        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}"); 
        //    }
        //}
        //static void ValidateAge(int age)
        //{
        //    if (age < 18)
        //    {
        //        throw new ArgumentException("Age must be 18 or older.");
        //    }
        //    Console.WriteLine("Age is valid.");
        //}
        //=====================================================================================================================================================================================

        //Assignment 12. Custom Exception 
        //Question: Create a custom exception class NegativeNumberException to handle negative inputs.
        //Write a method CheckNumber that throws this exception if the number is negative.
        //    Console.WriteLine("Enter the number  :");
        //    int number = Convert.ToInt32(Console.ReadLine());   
        //    NumberChecker checker = new NumberChecker();
        //    try
        //    {
        //        checker.CheckNumber(number);
        //        // This will throw NegativeNumberException
        //    } 
        //    catch (NegativeNumberException ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}"); 
        //    }

        //}
        //public class NegativeNumberException : Exception
        //{
        //    public NegativeNumberException(string message) : base(message)
        //    { }
        //}
        //public class NumberChecker
        //{
        //    public void CheckNumber(int number)
        //    {
        //        if (number < 0)
        //        {
        //            throw new NegativeNumberException("Negative numbers are not allowed.");
        //        }
        //        Console.WriteLine("Number is valid.");
        //    }
        //}

        //=================================================================================================================================================================================================
        //Assignment 14. Identify the Need for User-Defined Exceptions, Create Them, 
        //        and Throw Them
        //        Question: Create a custom exception NegativeNumberException to handle scenarios where a
        //negative number is passed to a method that only accepts positive numbers.Write code to throw
        //this exception if the number is negative.


        //    Console.WriteLine("Enter the number  :");
        //    int number = Convert.ToInt32(Console.ReadLine());   
        //    PositiveNumberChecker checker = new PositiveNumberChecker();
        //    try
        //    {
        //        checker.CheckPositive(number);
        //    }
        //    catch (NegativeNumberException ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //    }


        //}
        //public class PositiveNumberChecker
        //{
        //    public void CheckPositive(int number)
        //    {
        //        if (number < 0)
        //        {
        //            throw new NegativeNumberException("Negative numbers are not allowed.");
        //        }
        //        Console.WriteLine("Number is positive.");
        //    }


        //}
        //public class NegativeNumberException : Exception
        //{
        //    public NegativeNumberException(string message) : base(message)
        //    { }
        //}
        //============================================================================================================================================================================

        //Assignment 15. Explain the Difference between Exception (Checked Exceptions) 
        //and RuntimeException(Unchecked Exceptions)

        //    // 1. FileProcessor Test
        //    FileProcessor fileProcessor = new FileProcessor();
        //    fileProcessor.ReadFileContent("nonexistentfile.txt"); 
        //   // This will trigger and handle FileNotFoundException 

        //    // 2. MathOperations Test
        //    MathOperations mathOps = new MathOperations(); 
        //    mathOps.Divide(10, 0); 
        //    // This will trigger and handle DivideByZeroException 

        //    // 3. Person Test
        //    Person person = new Person();
        //    try 
        //    {
        //        person.SetAge(-5); 
        //        // This will trigger and handle InvalidAgeException
        //        }
        //    catch (InvalidAgeException ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //    }

        //}
        //// Custom Exception for Negative Numbers
        //public class NegativeNumberException : Exception 
        //{
        //    public NegativeNumberException(string message) : base(message)
        //    { }
        //} 
        //// Class to handle File Reading
        //  public class FileProcessor 
        //{
        //    public void ReadFileContent(string filePath)
        //    {
        //        try 
        //        {
        //            using (StreamReader reader = new StreamReader(filePath)) 
        //            {
        //                string content = reader.ReadToEnd();
        //                Console.WriteLine(content);
        //            }
        //        }
        //        catch (FileNotFoundException ex)
        //        {
        //            Console.WriteLine($"File not found: {filePath}");
        //        }
        //    }
        //}

        //// Class to handle Math Operations
        //public class MathOperations
        //{
        //    public int Divide(int a, int b) 
        //    {
        //        try
        //        {
        //            return a / b;
        //        }
        //        catch (DivideByZeroException) 
        //        {
        //            Console.WriteLine("Cannot divide by zero");
        //            return 0;
        //            // Return a default value or handle it as needed
        //        }
        //    }
        //}
        //// Custom Exception for Invalid Age
        //public class InvalidAgeException : Exception
        //{
        //    public InvalidAgeException(string message) : base(message) 
        //    { }
        //} // Class to handle Person's Age
        //public class Person
        //{
        //    public int Age { get; set; }
        //    public void SetAge(int age)
        //    {
        //        if (age < 0 || age > 120)
        //        {
        //            throw new InvalidAgeException("Invalid age provided");
        //        }
        //        Age = age;
        //    }
    }

}

