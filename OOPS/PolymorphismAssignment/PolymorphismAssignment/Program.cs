//Assignment 1: To demonstrate Polymorphism and its Advantages 
//Create a C# program demonstrating polymorphism by using a base class Shape and derived 
//classes Circle and Rectangle. Each derived class should implement a method Draw(). Show 
//how polymorphism helps in calling the correct method based on the object type

//using PolymorphismAssignment;
//class Program
//{
//    static void Main()
//    {
//        Shape[] shapes = new Shape[]
//        {
//            new Circle(),
//            new Rectangle()
//        };
//        foreach (Shape shape in shapes)
//        {
//            shape.Draw();
//        }


//    }
//}

//========================================================================================================================================
//Assignment 2. Method Overloading and its uses 
//Create a C# program to show method overloading by implementing a Multiply method with 
//different parameter types, numbers and order. 
//using PolymorphismAssignment;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculator calculator = new Calculator();
//        Console.WriteLine(calculator.Multiply(5, 10));
//        Console.WriteLine(calculator.Multiply(3, 2, 4));
//        Console.WriteLine(calculator.Multiply(2.3, 3.4));
//        Console.WriteLine(calculator.Multiply(25, 4.5));
//        Console.ReadLine();



//    }
//}

//================================================================================================================================
//Assignment 3. Method Overriding  
//Write a program demonstrating method overriding by creating a base class Vehicle and a derived 
//class Car that overrides the Drive() method.
//using PolymorphismAssignment;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Vehicle vehicle = new Vehicle();
//        Car car = new Car();
//        vehicle.Drive();
//        car.Drive();    
//        Console.ReadLine();
//    }
//}

//===========================================================================================================================
//Assignment 4. Scenario of Overriding
//Consider a scenario of payment processing where different payment methods
//(e.g., CreditCardPayment • PayPalPayment override the ProcessPayment) method 
//of a base class Payment. Write a C# program to demonstrate this scenario.

//using PolymorphismAssignment;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Payment pay = new Payment();
//        Payment pay1 = new CreditCardPayment();
//        Payment pay2 = new PayPalPayment();
//        pay.ProcessPayment();
//        pay1.ProcessPayment();
//        pay2.ProcessPayment();  
//        Console.ReadLine();
//    }
//}

//===============================================================================================================================
//Assignment 5. Polymorphism with Static Data and Methods. 
//Create a C# program that demonstrates polymorphism using a base class Employee and derived 
//classes Manager and Developer. Include a static field to keep track of the total number of 
//employees and a static method to display the total count. Use method overriding to demonstrate 
//polymorphism, while also explaining the need for static members in this context.

//using PolymorphismAssignment;
//using static PolymorphismAssignment.Manager;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Employee[] employees = new Employee[]
//        {
//            new Manager("zeba", new string[]
//            {
//                "Weekly review meeting", "project updates"
//            }),
//            new Developer("Naja", new string[] {
//                "Project Updates", "HR meeting"
//            })
//        };
//        foreach (var employee in employees)
//        {
//            employee.DisplayDetails();

//        }
//        Console.ReadLine();
//    }
//}

//=====================================================================================================================================
//Assignment 7: Understanding Early Binding and Late Binding in C# 
//Create a C# program that demonstrates early binding (compile-time polymorphism) using 
//method overloading and late binding (runtime polymorphism) using method overriding. This
//will help illustrate the differences between the two concepts in the context of polymorphism.
//using PolymorphismAssignment;

//class Program
//{
//    static void Main(string[] args)
//    {
//        MathOperations math = new MathOperations();
//        //method overriding
//        math.Calculate();
//        //method overloading
//        Console.WriteLine(math.Add(5, 7));
//        Console.WriteLine(math.Add(2.5,4.9));

//        AdvancedMathOperations advancedMath = new AdvancedMathOperations();
//        //method overriding
//        advancedMath.Calculate();
//        //method overloading
//        Console.WriteLine(advancedMath.Add(10,255,321));

//        Console.ReadLine();

//    }
//}

//======================================================================================================================
//Assignment 8. Achieving Runtime Polymorphism with Abstract Classes and 
//Interfaces in C# 
//Create a C# program that demonstrates how runtime polymorphism is achieved using abstract 
//classes and interfaces. Define an abstract class Shape and an interface IShape, implementing
//these in derived classes to showcase polymorphism. 
//using PolymorphismAssignment;

//class Program 
//{
//    static void Main() 
//    {
//        // Array of IShape
//        IShape[] shapes = new IShape[] 
//        {
//            new Circle2(),
//            new Rectangle2()
//        }; 
//        // Call the Draw method on each shape
//        foreach (var shape in shapes) 
//        {
//            shape.Draw();
//        }
//    }
//}

//================================================================================================================================
//Assignment 9. Demonstrating the Need for Multiple Inheritance of Interfaces  
//Create a C# program that demonstrates the concept of multiple inheritance through interfaces. 
//The program will define two interfaces, IMovable and IDrawable, and implement them in a class 
//Car that showcases how a class can inherit from multiple interfaces
//using PolymorphismAssignment;

//class Program
//{
//    static void Main() 
//    {
//        //object creation
//        Car2 myCar = new Car2();
//        //calling the function in the class
//        myCar.Move(); 
//        myCar.Draw();
//        Console.ReadLine();

//    }
//}
//==============================================================================================================================
//Assignment 10. Polymorphism in C# with Readonly Property 
//Create a C# program that demonstrates polymorphism with a readonly property. Define a base 
//class and derived classes where each class provides specific behavior for a method, while using a 
//readonly property to ensure that certain values cannot be modified after initialization.


//using PolymorphismAssignment;

//class Program 
//{
//    static void Main() 
//    {
//        Product[] products = new Product[]
//        {
//            new Electronics("Smartphone"),
//            new Groceries("Milk")
//        };
//        foreach (var product in products)
//        {
//            product.DisplayDetails();
//        }
//        Console.ReadLine();
//    }
//}