//Assignment 1. Abstract Class 
//Create an abstract class Vehicle that has an abstract method StartEngine() and a concrete method 
//StopEngine(). Create derived classes Car and Motorcycle that implement the StartEngine() 
//method and override it to show specific behavior for each type of vehicle. 

//using OOPS_ASSIGNMENT4_abstract__partial__interface;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Vehicle car = new Car();
//        Vehicle motorcycle = new Motorcycle();
//        car.StartEngine();
//        car.StopEngine();
//        motorcycle.StartEngine();
//        motorcycle.StopEngine();
//        Console.ReadLine();

//    }
//}

//===============================================================================================================================================================
//Assignment 2. Virtual Functions 
//Create a base class Animal with a virtual method MakeSound(). Derive classes Dog and Cat that 
//override the MakeSound() method to provide their specific implementation. 

using OOPS_ASSIGNMENT4_abstract__partial__interface;
using System.ComponentModel;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.Security.Claims;
using static System.Reflection.Metadata.BlobBuilder;
using System;
using static System.Formats.Asn1.AsnWriter;
using System.Runtime.ConstrainedExecution;
using Microsoft.VisualBasic;
using System.Xml.Linq;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        ////Calling Animal class
        //Animal animal = new Animal();
        //animal.MakeSound();
        ////Calling derived class Dog
        //Dog dog = new Dog();
        //dog.MakeSound();
        ////Calling derived class cat
        //Cat cat = new Cat();
        //cat.MakeSound();
        //Console.ReadLine();



        //=====================================================================================================================================
        //Assignment 3.Interface
        //Create an interface IDrive with a method Drive(). Implement this interface in a Car and Truck
        //class, with each class having its own implementation of Drive().
        ////Creating objects for the classes
        //Car2 car = new Car2();
        //Truck truck = new Truck();
        ////Calling methods
        //car.Drive();
        //truck.Drive();
        //Console.ReadLine(); 


        //====================================================================================================================================================================
        //Assignment 4. Interface vs. Abstract Class 
        //Write a program that demonstrates the difference between an abstract class and an interface by
        //creating an abstract class Bird with an abstract method Fly(), and an interface ISwim with a
        //method Swim().

        ////Creating object for classes
        //Bird eagle = new Eagle();
        //Bird penguin = new Penguin();

        ////calling the methods
        //eagle.Fly();
        //penguin.Fly();

        ////giving object for interface oof class penguin
        //Iswim iswim = new Penguin();

        //iswim.Swim();
        //Console.ReadLine();



        //========================================================================================================================================================================
        //Assignment 5. Static Class 
        //Create a static class MathOperations with a static method Add() and Multiply(). Demonstrate
        //calling these methods without creating an instance of the class. 

        ////Calling static method without creating instance
        //int sum = MathOperations.Add(10, 35);
        //int product = MathOperations.Multiply(10, 2);

        //Console.WriteLine($"{sum} is the sum");
        //Console.WriteLine($"{product} is the product");
        //Console.ReadLine();

        //=========================================================================================================================================================================
        //Assignment 6.Extension Methods
        //Create an extension method IsEven() for the int type that returns true if the number is even and
        //false if it is odd.
        ////Asking the user to enter the number
        //Console.WriteLine("Enter the number");
        //int number = Convert.ToInt32(Console.ReadLine());
        ////checking if number is even
        //Console.WriteLine($"{number} is even : {number.IsEven()}");
        //Console.ReadLine();


        //=======================================================================================================================================================================================
        //Assignment 7.Partial Class
        //Create a partial class Person that is defined in two files.One file should have the property Name,
        //and the other file should have the method ShowDetails(). 

        ////Creating object for the partial class
        //Person person = new Person();
        ////Assigning Values
        //person.FirstName = "Shirin";
        //person.LastName = "Sadath";
        //person.Age = 22;
        ////Displying the details
        //person.ShowDetails();
        //Console.ReadLine();


        //=======================================================================================================================================================================
        //Assignment 8.Partial Methods
        //Create a partial class Employee with a partial method CalculateSalary(). Implement the partial
        //method in another part of the class and demonstrate its usage.

        //Employee employee = new Employee()
        //{
        //    FullName = "Amina Renna",
        //    Department = "AEI",
        //    DaysWorked = 35,
        //    DailyWage = 1000
        //};
        //employee.DisplayDetails();
        //Console.ReadLine();

        //==========================================================================================================================================================================
        //Assignment 9.Indexer
        //Create a Library class that contains an array of Book objects.Implement an indexer that allows
        //accessing the books by index.Write a method to display all the books in the library.
        ////calling the class library with the maximum size os index
        //Library library = new Library(3);
        ////Adding values to the book
        //library[0] = new Book(" Anna Karenina ", "Leo Tolstoy");
        //library[1] = new Book("The Shining", "Stephen King "); 
        //library[2] = new Book("The Handmaid’s Tale", "Margaret Atwood");
        ////Displaying the details
        //library.DisplayBooks();
        //Console.ReadLine();

        //=========================================================================================================================================================================================
        //Assignment 10.Exception Handling
        //Write a method Divide that takes two integers as input and returns their division. If a division by
        //zero occurs, catch the exception and display a custom error message. Demonstrate exception
        //handling with a try-catch-finally block.
        ////Method Divide 
        //static int Divide(int num1, int num2)
        //{
        //    try
        //    {
        //        return num1 / num2;

        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //     Console.WriteLine($"Error occurred : {ex.Message}");
        //    return 0;
        //    }
        //    finally
        //    {
        //      Console.WriteLine("Operation Finished");
        //    }
        //}
        ////Number1
        //Console.WriteLine("Enter the 1st number");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        ////Number 2
        //Console.WriteLine("Enter the 2nd Number");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //Printing the result
        //int Result = Divide(num1, num2);
        //Console.WriteLine($"Result : {Result}");
        //Console.ReadLine();

        //============================================================================================================================================
        //        Assignment 11.Enum
        //Create an enum CarType with values Sedan, SUV, Truck, and Coupe.Write a Car class with a
        //property Type of type CarType.Write a method that takes a CarType value and displays a
        //message specific to that type of car.

        //Car3 Car1 = new Car3(CarType.Sedan);
        //Car3 Car2 = new Car3(CarType.Truck);
        //Car1.DisplayCarType(Car1.Type);
        //Car2.DisplayCarType(Car2.Type);
        //Console.ReadLine();

        //======================================================================================================================
        //Assignment 12.Attributes
        //Define a custom attribute DeveloperAttribute that takes the name of the developer and the date
        //when the code was last modified.Apply this attribute to a class Calculator and its method Add.
        //Retrieve and display the attribute information at runtime.

        // Get the attribute applied to the class
        Type type = typeof(Calculator);
        DeveloperAttribute classAttribute = (DeveloperAttribute)Attribute.GetCustomAttribute(type, typeof(DeveloperAttribute));
        if (classAttribute != null) 
        {
            Console.WriteLine($"Class {type.Name} was developed by {classAttribute.DeveloperName} on {classAttribute.LastModified}");
        }
        // Get the attribute applied to the method
        MethodInfo method = type.GetMethod("Add");

        DeveloperAttribute methodAttribute = (DeveloperAttribute)Attribute.GetCustomAttribute(method, typeof(DeveloperAttribute));
        if (methodAttribute != null)
        {
            Console.WriteLine($"Method {method.Name} was developed by {methodAttribute.DeveloperName} on {methodAttribute.LastModified}");
        }



    }
}