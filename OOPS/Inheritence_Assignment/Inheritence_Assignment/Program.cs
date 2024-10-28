//Lab 1. Single Inheritance 
//In Single Inheritance, a derived class inherits from a single base class. 
//Problem:
//Create a base class Person with properties like Name and Age. Derive a class Student from
//Person and add a property Grade. Create objects and display the data. 

//using Inheritence_Assignment;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Person p1 = new Person("Zeba", 23);
//        Student s1 = new Student("Naja", 22, "A+");
//        Console.ReadLine();
//    }
//}

//================================================================================================================================================================

//Lab 2. Multilevel Inheritance 
//In Multilevel Inheritance, a class is derived from another derived class. 
//Problem:
//Create a base class Animal with a method Eat(). Derive a class Dog that inherits Animal and add 
//a method Bark(). Further derive a class Puppy from Dog and add a method Weep(). Show the 
//behavior. 

//using Inheritence_Assignment;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Animal A= new Animal();
//        A.Eat();
//        Dog D = new Dog();
//        D.Eat();
//        D.Bark();
//        Puppy p = new Puppy();
//        p.Eat();
//        p.Bark();
//        p.Weep();

//        Console.ReadLine();
//    }
//}

//==============================================================================================================================
//Lab 3. Multiple Inheritance (via Interfaces) 
//C# does not support multiple inheritance directly, but it can be achieved using interfaces. 
//Problem: 
//Create two interfaces IPrintable and IScannable with respective methods Print() and Scan(). 
//Implement both interfaces in a class PrinterScanner. 
//using Inheritence_Assignment;

//class Program
//{
//    static void Main(string[] args)
//    {
//        PrinterScanner scanner = new PrinterScanner();
//        scanner.Print();
//        scanner.Scan();
//        Console.ReadLine();

//    }
//}

//================================================================================================================================================
//Lab 4. Hierarchical Inheritance 
//In Hierarchical Inheritance, multiple derived classes inherit from a single base class. 
//Problem:
//Create a base class Shape with a method Draw(). Create two derived classes Circle and 
//Rectangle, both inheriting from Shape, and override the Draw() method to show specific 
//behavior.

//using Inheritence_Assignment;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Shape shape = new Shape();
//        Circle circle = new Circle();
//        Rectange rect = new Rectange();

//        shape.Draw();
//        circle.Draw();
//        rect.Draw();

//        Console.ReadLine();
//    }
//}

//=================================================================================================================================================
//Hybrid inheritance combines multiple types of inheritance. Since C# doesn't support direct 
//multiple inheritance, hybrid inheritance is implemented using interfaces.
//Problem: 
//Create two interfaces IMovable and IRechargeable. Create a class Vehicle implementing
//IMovable and derive ElectricCar from Vehicle implementing both interfaces.

//using Inheritence_Assignment;

//class Program
//{
//    static void Main(string[] args)
//    {
//        ElectricCar tesla = new ElectricCar();
//        tesla.Move();
//        tesla.Recharge();
//        Console.ReadLine();

//    }
//}

//============================================================================================================================================================
//Lab 6. Overriding Methods in Inheritance 
//Demonstrate method overriding where a base class method is overridden in the derived class. 
//Problem:
//Create a class Employee with a method Work(). Derive a class Manager that overrides the 
//Work() method to show a different implementation.

//using Inheritence_Assignment;

//class Program
//{
//    static void Main()
//    {
//        Employee employee = new Employee();
//        Manager manager = new Manager();


//        employee.Work();

//        manager.Work();
//        Console.ReadLine();
//    }
//}


//=====================================================================================================================================================================================

//Lab 7. Abstract Classes 
//Create an abstract class and demonstrate inheritance with abstract methods.
//Problem: 
//Create an abstract class Vehicle with an abstract method Drive(). Create two derived classes Car 
//and Bike that implement the Drive() method.

//using Inheritence_Assignment;

//class Program
//{
//    static void Main()
//    {
//        Vehicle2 car = new Car();
//        Vehicle2 bike = new Bike();


//        car.Drive(); 
//        bike.Drive(); 

//        Console.ReadLine();
//    }

//}

//====================================================================================================================================================================================
//Lab 8. Sealed Classes 
//Create a class that cannot be inherited using the sealed keyword.
//Problem: 
//Create a sealed class MathOperations with a method Add(). Show that it cannot be inherited.
using Inheritence_Assignment;

class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();
        Console.WriteLine(math.Add(3, 4));


    }
}


//=================================================================================================================================================
//Lab 9. Constructor Chaining 
//Demonstrate how constructors are called in a class hierarchy. 
//Problem:
//Create a base class Person with a parameterized constructor. Create a derived class Employee
//that calls the base class constructor. 

//using Inheritence_Assignment;

//class Program
//{
//    static void Main(string[] args) 
//    {

//        Volunteer volunteer = new Volunteer("shahin", 6252, 214569);
//        Console.ReadLine();
//    }
//}

//=================================================================================================================================================================

//Lab 10. Interface Inheritance 
//Demonstrate that one interface can inherit from another. 
//Problem: 
//Create an interface IDriveable with a method Drive(). Create another interface IRaceable that
//inherits from IDriveable and adds a method Race(). 

//using Inheritence_Assignment;

//class Program
//{
//    static void Main()
//    {
//        SportsCar myCar = new SportsCar();
//        myCar.Drive(); 
//        myCar.Race();  
//        Console.ReadLine();
//    }
//}

//=========================================================================================================================================
//Lab 11. IS-A Relationship (Inheritance) 
//Problem: 
//Create a base class Animal with properties like Name and methods like Eat(). Create a derived class
//Dog that inherits from Animal and adds its own method Bark(). Show how the IS-A relationship 
//works. 
//using Inheritence_Assignment;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Dog2 dog = new Dog2("Lucky");
//        dog.Eat();
//        dog.Bark();
//        Console.ReadLine();

//    }
//}

//=======================================================================================================================================================
//Lab 12.HAS-A Relationship (Composition) 
//Problem:
//Create a class Engine with properties like HorsePower. Create a class Car that contains an instance 
//of Engine and shows the HAS-A relationship. Demonstrate how the Car can use its Engine to show 
//engine-related details. 

//using Inheritence_Assignment;

//class Program
//{
//    static void Main()
//    {       
//        Engine engine = new Engine { HorsePower = 150 };       
//        Car2 car = new Car2 { Engine = engine };        
//        car.ShowEngineDetails();
//        Console.ReadLine();
//    }
//}

//======================================================================================================================================
//Lab 13. Calling Base Class Method Using base 
//Problem: 
//Create a base class Person with a method DisplayInfo(). Derive a class Employee that overrides 
//DisplayInfo() but still calls the base class's DisplayInfo() using base.
//using Inheritence_Assignment;

//class Program
//{
//    static void Main()
//    {
//        Employee3 employee = new Employee3();
//        employee.DisplayInfo();
//        Console.ReadLine();
//    }
//}

//============================================================================================================================================
//Lab 14. Accessing Base Class Variable Using base  
//Problem:
//Create a base class Person with a property Name. In the derived class Student, hide the Name 
//property using the new keyword and use base to access the base class's Name property. 

//using Inheritence_Assignment;

//class Program
//{
//    static void Main()
//    {
//        Student student = new Student();
//        ((Person4)student).Name = "Thasreena k";
//        student.Name = "Thasreena Sadath";
//        student.ShowNames();
//        Console.ReadLine();
//    }
//}

//=========================================================================================================================================
//Lab 15. Calling Base Class Constructor Using base 
//This assignment demonstrates how to use the base keyword to call the base class constructor
//from the derived class constructor. 
//Problem:
//Create a base class Vehicle with a constructor that accepts brand. Derive a class Car that passes 
//values to the base class constructor using base.

//using Inheritence_Assignment;

//class Program
//{ 
//    static void Main()
//    {
//        Car3 car = new Car3("Toyota");
//        car.ShowBrand();
//        Console.ReadLine();
//    }
//}