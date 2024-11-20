//Assignment 1. Anonymous Types
//Question:
//Create an anonymous type to represent a book with properties for Title, Author, and Price.
//Display the details of the book.
//using System;
//using System.Runtime.Intrinsics.X86;
//class Program
//{
//    static void Main(string[] args)
//    {
//        //Create an anonymous type
//        var Book = new { Title = "A little life", Author = "Hanya Yanagihara", Price = 2150 };
//        //Dispalying the details

//        Console.Write("Title : " + Book.Title + " , ");
//        Console.Write("Author : " + Book.Author + " , ");
//        Console.WriteLine("Price : " + Book.Price);

//        Console.ReadLine();
//    }
//}

//===================================================================================================================================================

//    Assignment 2. Var and Dynamic
//Question:
//1. Declare a var variable to hold a list of integers, add some numbers to it, and print them.
//2. Declare a dynamic variable, assign different types of values to it, and observe the
//behavior.

//    static void Main(string[] args)

//    {
//        //Var type
//        var numbers = new int[] { 1, 2, 3, 4, 5 };
//        Console.WriteLine("Array of numbers : ");
//        foreach (var number in numbers)
//        {
//            Console.WriteLine(number);
//        }
//        //Dynamic type
//        dynamic Value = 10;
//        Console.WriteLine($"{Value} it is of type : {Value.GetType()}");
//        //changing the dynamic by assigning value of other datatype
//        Value = "Hello";
//        Console.WriteLine($"{Value} it is of type : {Value.GetType()}");
//        Value = DateTime.Now;
//        Console.WriteLine($"{Value} it is of type : {Value.GetType()}");
//        Value = 20.25;
//        Console.WriteLine($"{Value} it is of type : {Value.GetType()}");
//        Value = 20.25;
//        Console.ReadLine();
//    }



//}



//============================================================================================================================================================================

//    Assignment 3. Delegates
//Question:
//Create a simple calculator using delegates.Define a delegate OperationDelegate that can
//represent different arithmetic operations (addition, subtraction, multiplication, division).
//Implement methods for each operation and allow the user to select an operation to perform on
//two input numbers.
//Requirements:
//1. Define a delegate called OperationDelegate that takes two double parameters and returns
//a double result.
//2. Implement methods for addition, subtraction, multiplication, and division.
//3. Use the delegate to call the selected method.
//4. Allow the user to input two numbers and choose an operation.
//5. Display the result of the operation.

//class Program
//{
//    public delegate double OperationDelegate(double x, double y);
//    static void Main()
//    {
//        // Input two numbers from the user
//        Console.WriteLine("Enter the first number:");
//        double num1 = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Enter the second number:");
//        double num2 = Convert.ToDouble(Console.ReadLine());
//        // Select the operation
//        Console.WriteLine("Choose an operation: +, -, *, /");
//        string operation = Console.ReadLine();
//        // Initialize the delegate with the appropriate method
//        OperationDelegate operationDelegate = null;
//        switch (operation)
//        {
//            case "+":
//                operationDelegate = Add;
//                break;
//            case "-":
//                operationDelegate = Subtract;
//                break;
//            case "*":
//                operationDelegate = Multiply;
//                break;
//            case "/":
//                operationDelegate = Divide;
//                break;
//            default:
//                Console.WriteLine("Error: Invalid operation selected.");
//                return;
//        }
//        if (operationDelegate != null)
//        { // Perform the operation and display the result
//            double result = operationDelegate(num1, num2);
//            Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
//        }
//        else
//        {
//            Console.WriteLine("An unknown error occurred.");
//        }
//    }

//    // Method for addition
//    static double Add(double x, double y)
//    {
//        return x + y;
//    }
//    // Method for subtraction
//    static double Subtract(double x, double y)
//    {
//        return x - y;
//    }
//    // Method for multiplication
//    static double Multiply(double x, double y)
//    {
//        return x * y;
//    }
//    // Method for division
//    static double Divide(double x, double y)
//    {
//        if (y == 0)
//        {
//            Console.WriteLine("Error: Division by zero.");
//            return 0;
//        }
//        return x / y;

//    }

//}

//=======================================================================================================================================

//Assignment 4. Events
//Question:
//Create an event called OnCompleted in a class Process. Raise the event when a process is
//completed. Subscribe to the event from the main program to display a message.


//using OOPS_Assignment_7;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Process p = new Process();
//        p.OnCompleted += Process_OnCompleted;

//        p.StarttheProcess();

//        Console.ReadLine();

//    }
//    private static void Process_OnCompleted(object sender, EventArgs e)
//    {
//        Console.WriteLine("Process completed successfully");
//    }
//}
//===================================================================================================================================
//Assignment 5. Anonymous Methods
//Question:
//Write a delegate GreetDelegate that takes a string parameter. Assign an anonymous method to
//the delegate that prints a greeting message.

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    //    public delegate void GreetDelegate(string Name);

    //    static void Main(string[] args)
    //    {
    //        GreetDelegate Greet = delegate (string Name)
    //        {
    //            Console.WriteLine($"Hey, Its me {Name}!!!");
    //        };
    //        Greet("Zeba");
    //        Console.ReadLine();

    //    }
    //}


    //==============================================================================================================================================================
    //Assignment 6. Lambda Expressions
    //    Question:
    //Write a lambda expression that takes two integers and returns their product.Use Func<int, int,
    //int> for the delegate type.


    //static void Main()
    //{
    //    //lambda expression that takes two integers and returns their product
    //    Func<int, int, int> multiply = (a, b) => a * b;
    //    // Test the lambda expression
    //    int result = multiply(20, 10);
    //    Console.WriteLine($"The product of 20 and 10 is: {result}");
    //    Console.ReadLine();
    //}

    //==========================================================================================================================================================================
    //Assignment 7. Expression Tree
    //    Question:
    //Create an expression tree for a lambda expression that adds two integers.Compile and execute
    //    the expression.


    //static void Main()
    //{
    //    //Create parameter expressions
    //    ParameterExpression paramA = Expression.Parameter(typeof(int), "a");
    //    ParameterExpression paramB = Expression.Parameter(typeof(int), "b");
    //    BinaryExpression body = Expression.Add(paramA, paramB);
    //    //Create the lambda expression tree
    //    Expression<Func<int, int, int>> expression = Expression.Lambda<Func<int, int, int>>(body, paramA, paramB);
    //    //Compile the expression tree into a delegate
    //    Func<int, int, int> add = expression.Compile();

    //    int result = add(25, 10);
    //    Console.WriteLine($"The result of adding 25 and 10 is: {result}");
    //}

    //=========================================================================================================================================================================================

    //    Assignment 8. Using Delegates to Hold Methods with the Same Signature
    //Question:
    //Create a delegate called StringOperationDelegate that accepts a string parameter and returns a
    //string. Write three different methods that modify the string in different ways (e.g., convert to
    //uppercase, reverse, add a prefix). Use the delegate to call each method.

    //public delegate string StringOperationDelegate(string input);


    //static void Main(string[] args)
    //{
    //    string ToUpperCase(string input)
    //    {
    //        return input.ToUpper();
    //    }
    //    string ReverseString(string input)
    //    {
    //        char[] chars = input.ToCharArray();
    //        Array.Reverse(chars);
    //        return new string(chars);

    //    }
    //    string AddPrefix(string input)
    //    {
    //        return  "hi " + input;
    //    }
    //    StringOperationDelegate stringOperation = ToUpperCase;
    //    Console.WriteLine("Result of uppercase : " + stringOperation("Home"));

    //    StringOperationDelegate stringOperation2   = ReverseString;
    //    Console.WriteLine("Reversed String : " + stringOperation2("Hi Hoe are you"));

    //    StringOperationDelegate stringOperation3 = AddPrefix;
    //    Console.WriteLine("With Prefix : " + stringOperation3(" Shirin "));
    //    Console.ReadLine();


    //}

    //========================================================================================================================================
    //Assignment 9. Lambda Expressions to Filter and Process Lists 
    //    Question: 
    //Given a list of products with properties Name and Price, use lambda expressions to: 
    //1. Filter the list to find products that cost more than $50. 
    //2. Sort the list by price in descending order.
    //3. Select and display only the names of products from the filtered list. 

    //public class Product
    //{
    //    public string Name { get; set; }
    //    public double Price { get; set; }


    //}
    //static void Main()
    //{
    //    List<Product> products = new List<Product>
    //    {
    //        new Product { Name = "Laptop", Price = 100000 },
    //        new Product { Name = "Smartphone", Price = 798 },
    //        new Product { Name = "Tablet", Price = 200 },
    //        new Product { Name = "Headphones", Price = 48 },
    //        new Product { Name = "Smartwatch", Price = 300 },
    //    };
    //    var filteredProducts = products.Where(p => p.Price > 50);

    //    var sortedProducts = filteredProducts.OrderByDescending(p => p.Price);

    //    var productNames = sortedProducts.Select(p => p.Name);

    //    Console.WriteLine("Products that cost more than $50, sorted by price in descending order:");
    //    foreach (var name in productNames)
    //    {
    //        Console.WriteLine(name);
    //    }
    //}

    //=======================================================================================================================================================

    //    Assignment 10. Delegate as a Callback Mechanism
    //Question: 
    //Create a delegate called CalculationDelegate that takes two integers and returns an integer. 
    //Implement methods for addition and subtraction, and write a method Calculate that accepts two
    //integers and a delegate as parameters.Use the delegate to perform addition and subtraction
    //operations by passing different methods. 


    //public delegate int CalculationDelegate(int a, int b);

    //static void Main()
    //{
    //    int Add(int a, int b)
    //    {
    //        return a + b;
    //    }


    //    int Subtract(int a, int b)
    //    {
    //        return a - b;
    //    }


    //    void Calculate(int a, int b, CalculationDelegate operation)
    //    {
    //        int result = operation(a, b);
    //        Console.WriteLine("Result: " + result);
    //    }


    //    CalculationDelegate addDelegate = Add;
    //    Calculate(10, 5, addDelegate);


    //    CalculationDelegate subtractDelegate = Subtract;
    //    Calculate(10, 5, subtractDelegate);
    //}

    //=========================================================================================================================

    //    Assignment 11. Introduction to Asynchronous Programming
    //Question: 
    //Write a C# program that simulates a long-running operation using Task.Delay() and runs 
    //asynchronously.Display a message before and after the operation completes. 


    //static async Task Main(string[] args)
    //{
    //    Console.WriteLine("Operation started..."); 

    //    await LongRunningOperationAsync(); 
    //    Console.WriteLine("Operation completed."); 
    //}
    //static async Task LongRunningOperationAsync() 
    //{ 
    //    await Task.Delay(3000);
    //}

    //==========================================================================================================================

    //    Assignment 12. Async and Await Keywords
    //Question: 
    //Create a method that downloads data from a sample URL asynchronously.Use HttpClient to
    //fetch the data and print the length of the content.The method should use async and await
    //keywords.

    // static async Task Main(string[] args)
    //{
    //    string url = "https://www.people.com"; 
    //    try
    //    {
    //        int contentLength = await DownloadDataAsync(url);
    //        Console.WriteLine($"The length of the content from the URL is: {contentLength}");
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine($"An error occurred: {ex.Message}"); 
    //    }
    //}
    //static async Task<int> DownloadDataAsync(string url) 
    //{
    //    using (HttpClient client = new HttpClient())
    //    {
    //        HttpResponseMessage response = await client.GetAsync(url);
    //        response.EnsureSuccessStatusCode(); 
    //        string content = await response.Content.ReadAsStringAsync(); 
    //        return content.Length;
    //    }
    //}

    //====================================================================================================
    //    Assignment 13. Task and Task<T>
    //Question: 
    //Write a C# program that calculates the sum of an array of integers asynchronously using 
    //Task<int>.Return the result from the asynchronous method and display it.

    //static async Task Main(string[] args)
    //{
    //   int[] numbers = { 1, 2, 3, 4, 5 };
    //   try
    //   {
    //   int sum = await CalculateSumAsync(numbers);
    //   Console.WriteLine($"The sum of the array is: {sum}");
    //   }
    //   catch (Exception ex)
    //   {
    //   Console.WriteLine($"An error occurred: {ex.Message}");
    //   }
    //}

    //static async Task<int> CalculateSumAsync(int[] numbers) 
    //{
    //    return await Task.Run(() => 
    //    {
    //        int sum = 0; 
    //        foreach (int number in numbers)
    //        {
    //            sum += number; 
    //        }
    //        return sum; 
    //    });
    //}

    //==================================================================================================================

    //    Assignment 14. Handling Exceptions in Asynchronous Methods
    //Question: 
    //Modify the previous example to handle exceptions that might occur during the sum calculation.
    //Catch the exception in the Main method and display an error message.

    //static async Task Main(string[] args)
    //{
    //    string url = "https://www.example.com";
    //    try
    //    {
    //        int contentLength = await DownloadDataAsync(url);
    //        Console.WriteLine($"The length of the content from the URL is: {contentLength}");
    //    }
    //    catch (HttpRequestException ex)
    //    {
    //        Console.WriteLine($"An error occurred while fetching the data: {ex.Message}");
    //    }
    //    catch (TaskCanceledException ex)
    //    {
    //        Console.WriteLine($"The request was canceled: {ex.Message}");
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    //    }
    //}
    //static async Task<int> DownloadDataAsync(string url)
    //{
    //    using (HttpClient client = new HttpClient())
    //    {
    //        HttpResponseMessage response = await client.GetAsync(url);
    //        response.EnsureSuccessStatusCode();
    //        string content = await response.Content.ReadAsStringAsync();
    //        return content.Length;
    //    }
    //}

    //===================================================================================================================================
    //    Assignment 15. Parallel Programming with Task Parallel Library(TPL)
    //Question: 
    //Create a program that runs multiple tasks in parallel to simulate multiple operations, such as 
    //calculating the factorial of different numbers.Print the result of each task when completed.



    //static void Main(string[] args)
    //{
    //    List<int> numbers = new List<int> { 5, 6, 7, 8 };


    //    Parallel.For(0, 4, i =>
    //    {
    //        int number = numbers[i];
    //        long factorial = Factorial(number);
    //        Console.WriteLine($"Factorial of {number} is {factorial}");
    //    });


    //}
    //static long Factorial(int number) 
    //{
    //    if (number <= 1) return 1;
    //    return number * Factorial(number - 1);
    //}

    //===================================================================================================================================================

    //    Assignment 16. LINQ Query Syntax and Method Syntax
    //Question: Write a LINQ query using both query syntax and method syntax to retrieve all 
    //numbers greater than 5 from a list of integers. 

    //static void Main()
    //{
    //    List<int> numbers = new List<int> { 1, 2, 3, 6, 8, 10 }; 
    //    var querySyntax = from num in numbers where num > 5 select num;
    //    List<int> numbers1  = new List<int> { 1, 9, 5, 12, 8, 10 };
    //    var methodSyntax = numbers1.Where(num => num > 5); 
    //    Console.WriteLine("Numbers greater than 5 using query syntax:");
    //    foreach (var num in querySyntax)
    //    {
    //        Console.WriteLine(num);
    //    }
    //    Console.WriteLine("\nNumbers greater than 5 using method syntax:");
    //    foreach (var num in methodSyntax)
    //        {
    //        Console.WriteLine(num); 
    //    }
    //}

    //=================================================================================================================================================
    //    Assignment 17. LINQ Operators(Select, Where, GroupBy, Join, etc.)
    //Question 1: Given a list of strings representing student names, write a LINQ query that selects
    //the names starting with the letter 'A' and orders them alphabetically.


    //static void Main()
    //{
    //    List<string> studentNames = new List<string> { "zeba", "naja", "Amina renna", "shenna", "nazree", "fathi", "nujoo", "Sali" }; 
    //    var querySyntax = from name in studentNames where name.StartsWith("A") orderby name select name;
    //    List<string> studentNames1 = new List<string> { "Alamzeba", "naja", "Amina renna", "shenna", "nazree", "fathi", "nujoo", "Sali" };
    //    var methodSyntax = studentNames1 .Where(name => name.StartsWith("A")) .OrderBy(name => name); 
    //    Console.WriteLine("Names starting with 'A' and ordered alphabetically (Query Syntax):");
    //    foreach (var name in querySyntax) 
    //    {
    //        Console.WriteLine(name); 
    //    }
    //    Console.WriteLine("\nNames starting with 'A' and ordered alphabetically (Method Syntax):");
    //    foreach (var name in methodSyntax) 
    //    { 
    //        Console.WriteLine(name);
    //    }
    //}

    //=============================================================================================================================================================================================

    //Assignment 18. LINQ to Objects
    //Question: Write a LINQ query to find the sum of all even numbers in an array of integers.

    //static void Main()
    //{
    //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //    var evenSumQuerySyntax = (from num in numbers where num % 2 == 0 select num).Sum();
    //    var evenSumMethodSyntax = numbers.Where(num => num % 2 == 0).Sum();
    //    Console.WriteLine($"Sum of all even numbers using Query Syntax: {evenSumQuerySyntax}"); 
    //    Console.WriteLine($"Sum of all even numbers using Method Syntax: {evenSumMethodSyntax}"); 
    //}

    //===================================================================================================================================.

    //    Assignment 19. LINQ to XML
    //Question: Create an XML document representing a list of books, and use LINQ to XML to
    //query the titles of books published after 2015.

    //static void Main()
    //{  XElement booksXml = new XElement("books",
    //    new XElement("book",
    //    new XElement("title", "The Great Gatsby"), 
    //    new XElement("author", "F. Scott Fitzgerald"), 
    //    new XElement("year", "1925") ),

    //    new XElement("book", 
    //    new XElement("title", "To Kill a Mockingbird"), 
    //    new XElement("author", "Harper Lee"), 
    //    new XElement("year", "1960") ),
    //    new XElement("book", 
    //    new XElement("title", "The Silent Patient"),
    //    new XElement("author", "Alex Michaelides"),
    //    new XElement("year", "2019") ) ); 
    //    var recentBooks = from book in booksXml.Elements("book") where (int)book.Element("year") > 2015 select book.Element("title").Value; 
    //    Console.WriteLine("Titles of books published after 2015:");
    //    foreach (var title in recentBooks) 
    //    {
    //        Console.WriteLine(title);
    //    }  

    //}

    //=====================================================================================================================================
    //Assignment 20. LINQ to SQL

    //    Question: Given a database table Employees with columns ID, Name, and Department, write a
    //LINQ to SQL query to select all employees from the "IT" department.



}






