//Assignment 1: Circle Class
//Problem Statement: Create a Circle class with a property for Radius. Implement a getter to
//retrieve the radius and a setter to ensure that the radius cannot be negative.



//class Program
//{
//    static void Main()
//    {
//        Circle c = new Circle(5);
//        Console.WriteLine($"Radius: {c.radius}");
//        Console.WriteLine($"Area: {c.Area()}");
//        c.radius = -2;
//        Console.WriteLine($"Radius after trying to set negative: {c.radius}");
//        Console.ReadLine();

//    }

//}

//----------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------
//Assignment 2: Employee Class
//Problem Statement: Design an Employee class with properties for Name and Salary. Use
//getters and setters to manage access to the salary, ensuring it cannot be set to a negative value.

//class Program
//{
//    static void Main(String[] args)
//    {
//        Employee employee = new Employee("zeba", 25000);
//        Console.WriteLine($"Salary of {employee.name} is {employee.salary}");
//        employee.salary = -1000;


//        Console.WriteLine($"salary after trying to make it negative is {employee.salary}");
//        Console.ReadLine();

//    }
//}
//

//=========================================================================================================================================================
//=========================================================================================================================================================

//Assignment 3: Library Management System
//Problem Statement: Design a library management system that manages books. Each book has a
//title, author, and ISBN number. The system should allow adding a book, removing a book, and
//displaying all books.

//using OOPS_Assignment_1;

//class Program
//{
//    static void Main()
//    {
//        Library library = new Library();

//        Book book1 = new Book("1984", "George Orwell", "123456789");
//        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "987654321");

//        library.AddBook(book1);
//        library.AddBook(book2);

//        //library.DisplayBook();

//        library.RemoveBook("123456789");

//        library.DisplayBook();

//    }
//}
//public class Book
//{
//    public string Title;
//    public string Author;
//    public string ISBN;

//    public Book(string tile, string author, string isbn)
//    {
//        Title = tile;
//        Author = author;
//        ISBN = isbn;
//    }

//}
//public class Library

//{
//    private List<Book> books = new List<Book>();
//    public void AddBook(Book book)
//    {
//        books.Add(book);
//        Console.WriteLine($"{book.Title} added");
//    }
//    public void RemoveBook(string isbn)
//    {
//        books.RemoveAll(b => b.ISBN == isbn);
//        Console.WriteLine("removed");
//    }
//    public void DisplayBook()
//    {
//        foreach (var book in books)
//        {
//            Console.WriteLine(book.Title);
//        }
//        Console.ReadLine();
//    }
//}

//==============================================================================================================================================
//==========================================================================================================================================================

//Assignment 4: Banking System
//Problem Statement: Create a simple banking system that allows account creation and basic
//transactions. Each account has an account number, account holder name, and balance. Implement
//deposit and withdrawal methods. Use getters and setters to manage access to the balance,
//ensuring it cannot be set to a negative value.



//using OOPS_Assignment_1;

//class Program
//{
//    static void Main()
//    {
//        Account account1 = new Account("123456", "neja fathima", 5000.0);

//        account1.Deposit(150.0);
//        account1.Withdraw(100.0);
//        account1.Withdraw(6000.0);
//        Console.WriteLine($"Final Balance: {account1.Balance}");
//        Console.ReadLine();
//    }
//}

//==========================================================================================================================================================
//==========================================================================================================================================================

//Assignment 5: Student Management System 
//Problem Statement: Develop a student management system that stores student details. Each 
//student has a name, ID, and a list of grades. Implement methods to add a grade and calculate the 
//average grade. 

//using OOPS_Assignment_1;

//class Program
//{
//    static void Main(String[] args)
//    {
//        Student student = new Student("Zeba Fathima", 6252);
//        student.AddGrade(76.4);
//        student.AddGrade(89);
//        student.AddGrade(90);
//        student.AddGrade(79);
//        student.AddGrade(85.9);

//        float Average = (float)student.AverageGrade();
//        Console.WriteLine($"Average grade of {student.Name} is {Average}");
//        Console.ReadLine();
//    }
//}

//===============================================================================================================================================================================
//========================================================================================================================================================================

//Assignment 6: Inventory System 
//Problem Statement: Create an inventory management system that manages items in a store. 
//Each item has a name, stock, and price. Implement methods to add, remove, and update items. 
//Use getters and setters to manage access to the stock and price, ensuring it cannot be set to a 
//negative value.






//class Program
//{
//    static void Main()
//    {
//        Inventory inventory = new Inventory();

//        inventory.AddItem("Laptop", 10, 10000);
//        inventory.AddItem("Phone", 20, 4900);

//        inventory.DisplayAllItems();

//        inventory.UpdateStock("Laptop", 15000);
//        inventory.UpdatePrice("Phone", 4500);

//        inventory.DisplayAllItems();

//        inventory.RemoveItem("Phone");

//        inventory.DisplayAllItems();
//        Console.ReadLine();
//    }
//}

//===============================================================================================================================
//===========================================================================================================================================
//Assignment 7
//using System;

//namespace ECommerceSystem
//{
//    public class ECommerce
//    {
//        private class Product
//        {
//            private string name;
//            private decimal price;
//            private int stock;
//            public string Name
//            {
//                get { return name; }
//                set { name = value; }
//            }
//            public decimal Price
//            {
//                get { return price; }
//                set
//                {
//                    if (value < 0)
//                    {
//                        throw new ArgumentException("Price cannot be negative.");
//                    }
//                    price = value;
//                }
//            }
//            public int Stock
//            {
//                get { return stock; }
//                set
//                {
//                    if (value < 0)
//                    {
//                        throw new ArgumentException("Stock cannot be less than zero.");
//                    }
//                    stock = value;
//                }
//            }
//            public Product(string name, decimal price, int stock)
//            {
//                Name = name;
//                Price = price;
//                Stock = stock;
//            }
//            public void Display()
//            {
//                Console.WriteLine($"\nProduct : {Name}, Price: {Price}, Stock: {Stock}");
//            }
//        }
//        private class Order
//        {
//            public void CreateOrder(Product product, int quantity)
//            {

//                if (quantity <= 0)
//                {
//                    Console.WriteLine("\nQuantity must be greater than zero.\n");
//                    return;
//                }

//                if (product.Stock >= quantity)
//                {
//                    product.Stock -= quantity;
//                    Console.WriteLine("\nUpdated Product Stock:");
//                    Console.WriteLine($"Order created for {quantity} of {product.Name}. Remaining stock: {product.Stock}");
//                }
//                else
//                {
//                    Console.WriteLine("\norder cannot be created");
//                    Console.WriteLine($"Not enough stock for {product.Name}. Available: {product.Stock}, Requested: {quantity}");

//                }
//            }
//        }


//        public static void Main(string[] args)
//        {
//            Product p1 = new Product("Moisturizer", 750.60m, 100);
//            Product p2 = new Product("Sunscreen", 360.40m, 50);
//            Product p3 = new Product("Chapstick", 150.80m, 30);
//            Console.WriteLine("Products available at the inventory");
//            p1.Display();
//            p2.Display();
//            p3.Display();
//            Order order = new Order();
//            order.CreateOrder(p1, 10);
//            order.CreateOrder(p2, 60);
//            p1.Display();
//            p2.Display();
//            Console.ReadLine();
//        }
//    }
//}


//======================================================================================================================================================================
//=======================================================================================================================================================================

//Assignment 8: Print Class 
//Problem Statement: Design a Print class that contains overloaded methods to print different 
//types of data: a string, an integer, and an array of integers.

//using OOPS_Assignment_1;

//Print print = new Print();
//print.ToPrint("Hi I am Shirin");
//print.ToPrint(98);
//int[] numbers = { 2, 3, 4, 5, 6, 7, 8, };
//print.ToPrint(numbers);
//Console.ReadLine();

//===================================================================================================================================================================================
//==================================================================================================================================================================================
//Assignment 9: Rectangle Class 
//Problem Statement: Create a Rectangle class with overloaded methods to calculate the area. 
//Implement methods that take either width and height or just one side length (for a square). 


//using OOPS_Assignment_1;

//class Program
//{
//    static void Main()
//    {
//        Rectangle r = new Rectangle();
//        r.ToCalculateArea(20, 22);
//        r.ToCalculateArea(35);
//        Console.ReadLine();
//    }
//}

//============================================================================================================================================================================================
//==============================================================================================================================================================================================

//Assignment 10: Time Class 
//Problem Statement: Create a Time class with overloaded methods to set the time. Implement 
//methods to set the time using hours and minutes, and another method to set the time using 
//seconds. 
//using OOPS_Assignment_1;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Time t = new Time();
//        t.DisplayTime(2, 80);
//        t.DisplayTime(5456);
//        Console.ReadLine();
//    }
//}

//======================================================================================================================================================================================================
//==========================================================================================================================================================================================================
//Assignment 11: Initializing a Static Field 
//Problem Statement: Create a class Bank that has a static field for the interest rate and a non
//static field for the account holder’s balance.Write a static constructor to initialize the interest 
//rate to a default value and a regular constructor for setting up the account balance. 

//using OOPS_Assignment_1;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Bank account1 = new Bank(15000, 254239852);
//        Console.Write($" of {account1.AccNumber} account number with {account1.Balance} and an interest rate of {Bank.InterestRate}");
//        Console.ReadLine();

//    }
//}

//===================================================================================================================================================================================================================
//========================================================================================================================================================================================================

//Assignment 12: Counting Objects with Static and Instance Fields
//Problem Statement: Create a class Car that counts how many instances of Car have been 
//created using a static counter.Initialize this counter using a static constructor.

//using OOPS_Assignment_1;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Car car1 = new Car();
//        Car car2 = new Car();
//        Car car3 = new Car();
//        Car car4 = new Car();
//        Car car5 = new Car();
//        Console.WriteLine($"The Car class has been called {Car.Count} times.");
//        Console.ReadLine();
//    }
//}

//================================================================================================================================================================================
//===================================================================================================================================================================================

//Assignment 13: Initializing Constants with Static Block 
//Problem Statement: Create a class MathOperations that initializes a static field representing the 
//value of Pi. Write a static constructor to assign this value. 


//using OOPS_Assignment_1;
//class Program
//{
//    static void Main(string[] args)
//    {
//        MathOperations M = new MathOperations();
//        Console.WriteLine($"the pi value is {MathOperations.PI}");
//        Console.ReadLine();
//    }
//}

//=========================================================================================================================================================================================
//===============================================================================================================================================================================

//Assignment 14: Initializing Configuration with Static Constructor 
//Problem Statement: Create a class Configuration to load system-wide settings (e.g., application 
//name) using a static constructor.Allow individual users to set preferences using an instance
//constructor.

//using OOPS_Assignment_1;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Configuration name1 = new Configuration("dundundundun");
//        Console.ReadLine();

//    }
//}

//==================================================================================================================================================================
//===========================================================================================================================================================================

//Assignment15: Implementing and Understanding Copy Constructor 
//Problem Statement: 
//Write a C# program that implements a copy constructor. The program should: 
//1. Create a class with several fields. 
//2.Provide a constructor to initialize those fields. 
//3. Provide a copy constructor that allows the creation of a new object from an existing 
//object. 
//4. Demonstrate how the copy constructor works by comparing objects created using it with
//objects created via direct assignment (which just copies references).

//using OOPS_Assignment_1;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Cars car1 = new Cars("Toyota Glana", 2023);
//        Console.WriteLine("original details");
//        car1.Display();

//        Cars Reference = car1;

//        Cars copyconstructorcar = new Cars(car1);

//        Reference.model = "Honda Mobilio";
//        Reference.year = 2018;

//        Console.WriteLine("\nAfter modifying reference copy");
//        Console.WriteLine("Original car details after change :");
//        car1.Display();

//        Console.WriteLine("\nDeep copy (unchanged) : ");
//        copyconstructorcar.Display();

//        copyconstructorcar.model = "Toyota Fortuner";
//        copyconstructorcar.year = 2024;

//        Console.WriteLine("\n After modifying deep copy : ");
//        Console.WriteLine("Deep copy details : ");
//        copyconstructorcar.Display();

//        Console.WriteLine("\nOriginal car details (unchanged) : ");
//        car1.Display();

//    }
//}

//==========================================================================================================================================================================
//===================================================================================================================================================================================
//Assignment 16: Identifying the Need for Chained Constructors 
//Tasks: 
//1.Create a class named Car with the following: 
//o Fields for make, model, year, and price. 
//o Multiple constructors: 
// A constructor that initializes only the make. 
// A constructor that initializes make and model. 
// A constructor that initializes make, model, and year. 
// A constructor that initializes all fields: make, model, year, and price. 
//o Use constructor chaining to avoid duplicating the logic for initializing fields. 
//2. In the Main() method: 
//o Create several Car objects using different constructors. 
//o Display the details of each car to verify that all fields are initialized correctly.

//using OOPS_Assignment_1;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Car1 c1 = new Car1("Benz");
//        Car1 c2 = new Car1("Toyota", "Glanza");
//        Car1 c3 = new Car1("Honda", "Mobilio", 2024);
//        Car1 c4 = new Car1("Toyota", "Fortuner", 2022, 650000);

//        Console.WriteLine("Car 1 details : ");
//        c1.Display();

//        Console.WriteLine("Car 2 details :");
//        c2.Display();

//        Console.WriteLine("Car 3 details : ");
//        c3.Display();

//        Console.WriteLine("Car 4 details : ");
//        c4.Display();

//    }
//}

//==========================================================================================================================================
//=====================================================================================================================================================


//Assignment 17: Understanding the Need for Constructor Overloading 
//Problem Statement: 
//Write a C# program that models a Product class with overloaded constructors. The class should: 
//1. Provide flexibility in product initialization based on the availability of price and discount 
//information. 
//2. Use constructor overloading to handle cases where only basic product information is 
//available, as well as cases where detailed information (price and discount) is provided. 
//Tasks: 
//1.Create a class named Product with the following: 
//o Fields for name, price, and discount. 
//o Three constructors: 
// A constructor that initializes only the name. 
// A constructor that initializes name and price. 
// A constructor that initializes name, price, and discount. 
//2. Implement a method CalculateFinalPrice() that computes the final price after applying 
//the discount (if applicable). 
//3. In the Main() method: 
//o Create different Product objects using various constructors. 
//o Display the details of each product, including the final price after any applicable 
//discount.

//using OOPS_Assignment_1;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Product p1 = new Product("Moisturizer");
//        Product p2 = new Product("Sunscreen", 250);
//        Product p3 = new Product("Toner", 300, 10);
//        Console.WriteLine("Product 1 : ");
//        p1.Display();
//        Console.WriteLine("Product 2 : ");
//        p2.Display();
//        Console.WriteLine("Product 3 : ");
//        p3.Display();
//        Console.ReadLine();
//    }
//}

//=============================================================================================================================================================
//========================================================================================================================================================
//Assignment 18: Exploring Different Ways to Initialize Objects  
//Problem Statement: 
//Write a C# program that demonstrates different ways to initialize an object of a class. The class 
//should represent a Product with properties such as Name, Price, and Category. Implement the 
//following methods of object initialization: 
//1.Constructor initialization.
//2.Object initializer syntax. 
//3.Static factory method. 
//4.Anonymous types.
//5.Reflection.
//6.Default values in constructors. 
//Tasks: 
//1.Create a class named Product with the following: 
//o Properties for Name, Price, and Category. 
//o A constructor that initializes all three properties. 
//o A static method to create a Product object. 
//o Use reflection to dynamically create a Product object. 
//o Implement a constructor that provides default values for the properties. 
//2. In the Main() method: 
//o Create instances of the Product class using the different initialization techniques 
//mentioned above. 
//o Display the details of each product. 

//using OOPS_Assignment_1;

//class Program()
//{
//    static void Main(string[] args)
//    {
//        //1.Constructor initialization
//        Product2 product1 = new Product2("Bottle", 250, "Containers and Packaging");
//        Console.WriteLine("Constructor initialization");
//        product1.Display();

//        //2.Object initializer syntax
//        Product2 product2 = new Product2 { Name = "spoon", Price = 200, Category = "Utensils" };
//        Console.WriteLine("Object initializer syntax");
//        product2.Display();

//        //3.Static factory method
//        Product2 product3 = Product2.CreateProduct("Knife", 260, "Utensils");
//        Console.WriteLine("Static factory method");
//        product3.Display();

//        //4.Anonymous types
//        var Anonymous = new { Name = "Aluminium container", Price = 150, Category = "Containers and Packaging" };
//        Console.WriteLine("Anonymous types");
//        Console.WriteLine($"Name : {Anonymous.Name}, Price : {Anonymous.Price}, Category : {Anonymous.Category}\n");

//        //5.Reflection
//        Type productType = typeof(Product2);
//        Product2 product4 = (Product2)Activator.CreateInstance(productType, new object[] {"Plate",2500, "Containers and Packaging" });
//        Console.WriteLine("Reflection");
//        product4.Display();

//        //6.Default values in constructors
//        Product2 product5 = new Product2();
//        Console.WriteLine("Default values in constructors");
//        product5.Display();
//    }
//}

//===========================================================================================================================================================================================
//======================================================================================================================================================================================================

//Assignment 19: Exploring Initialization Using Tuples and Records 
//Problem Statement: 
//Write a C# program that demonstrates object initialization using tuples and records. Create a 
//simple model for Student with properties like Name, Age, and Grade. Use tuples and records to 
//initialize and work with this model. 
//Tasks: 
//1.Create a Student class using the record keyword with properties Name, Age, and Grade. 
//2. Use tuples to store and retrieve student details. 
//3. Create a method that accepts a tuple as a parameter and returns a Student record. 
//4. Display the details of the students.

//using System;

//// 1: Create a Student class using the record keyword  with properties Name, Age, and Grade. 
//public record Student(string Name, int Age, string Grade);

//class Program
//{
//    static void Main()
//    {
//        // 2: Use tuples to store and retrieve student details
//        var studentTuple1 = ("Alice", 20, "A");
//        var studentTuple2 = ("Bob", 22, "B");

//        // 3: Create a method that accepts a tuple as a parameter and returns a Student record
//        static Student CreateStudent((string Name, int Age, string Grade) studentTuple)
//        {
//            return new Student(studentTuple.Name, studentTuple.Age, studentTuple.Grade);
//        }

//        Student student1 = CreateStudent(studentTuple1);
//        Student student2 = CreateStudent(studentTuple2);

//        // 4: Display the details of the students
//        Console.WriteLine($"Student 1: Name = {student1.Name}, Age = {student1.Age}, Grade = {student1.Grade}");
//        Console.WriteLine($"Student 2: Name = {student2.Name}, Age = {student2.Age}, Grade = {student2.Grade}");
//        Console.ReadLine();
//    }
//}




//=================================================================================================================================================================================================================
//=================================================================================================================================================================================================================
//Assignment 20: Shopping Cart 
//using System.Collections.Generic;

//Problem Statement: 
//You need to create a Shopping Cart class that holds a list of Product objects. The Product class
//will be a nested class. The system should allow users to add products to the cart and display the 
//total price. 
//Tasks: 
//1.Create a ShoppingCart class that contains:
//o A list of Product objects. 
//o Methods to add products and calculate the total price. 
//2. Create a nested Product class with properties for Name, Price, and Quantity. 
//3. Demonstrate adding products and displaying the total price in the Main() method. 

//using OOPS_Assignment_1;

//class Program
//{
//    static void Main()
//    {
//        ShoppingCart cart = new ShoppingCart();

//        cart.AddProduct(new ShoppingCart.Product("Apple",25, 5));
//        cart.AddProduct(new ShoppingCart.Product("Bread", 29, 2));
//        cart.AddProduct(new ShoppingCart.Product("Milk", 59, 3));

//        cart.DisplayCart();
//    }
//}

//==============================================================================================================================================================================================
//========================================================================================================================================================================================================
//Assignment 21: Banking System 


//Problem Statement: 
//You need to create a Bank class that contains a list of Customer objects. Each Customer can have 
//multiple Account objects (nested class). Implement methods to add customers, add accounts, and 
//display customer account details. 
//Tasks: 
//1.Create a Bank class with :
//o A list of Customer objects.
//o Methods to add customers and accounts, and to display customer details.
//2. Create a nested Customer class with properties for Name and a list of accounts. 
//3. Create a nested Account class with properties for AccountNumber and Balance. 
//4. Demonstrate the functionality in the Main() method.


//using OOPS_Assignment_1;

//class Program
//{
//    static void Main()
//    {
//        Bank2 bank = new Bank2();

//        bank.AddCustomer("Shirin Sadath");
//        bank.AddCustomer("Zeba Fathima");

//        bank.AddAccountToCustomer("Shirin Sadath", 123456, 10000.50);
//        bank.AddAccountToCustomer("Shirin Sadath", 654321, 20000.75);
//        bank.AddAccountToCustomer("Zeba Fathima", 112233, 15000.00);
//        bank.AddAccountToCustomer("Naja Fathima", 365541, 3000.25);


//        bank.DisplayCustomerDetails();
//    }
//}

//==========================================================================================================================================
//===========================================================================================================================================================
//Assignment 22: University System  
//Problem Statement: 
//You need to create a University class that holds a list of Department objects. Each Department 
//can have multiple Course objects (nested class). Implement methods to add departments, add 
//courses, and display course information. 
//Tasks: 
//1.Create a University class with :
//o A list of Department objects.
//o Methods to add departments and courses, and to display course details.
//2. Create a nested Department class with properties for Name and a list of courses. 
//3. Create a nested Course class with properties for CourseName, CourseCode, and Credits. 
//4. Demonstrate the functionality in the Main() method.


//using OOPS_Assignment_1;

//class Program
//{
//    static void Main()
//    {
//        University university = new University();


//        university.AddDepartment("Computer Science");
//        university.AddDepartment("Mathematics");


//        university.AddCourseToDepartment("Computer Science", "Data Structures", "CS101", 3);
//        university.AddCourseToDepartment("Computer Science", "Algorithms", "CS102", 4);
//        university.AddCourseToDepartment("Mathematics", "Calculus", "MATH101", 4);
//        university.AddCourseToDepartment("Science", "zoology", "BIO305", 5);

//        university.DisplayCourseDetails();
//        Console.ReadLine();
//    }
//}

