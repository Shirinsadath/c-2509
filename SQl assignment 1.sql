
--Insert into Employee
--values (123, 'Jane' , 'Smith', 'IT', 60000),
--(432, 'David', 'Lee', 'marketing', 55000);

--task3
--1. Retrieve all employee records from the Employees table.
--select * from Employee

--2. Retrieve the FirstName, LastName,
--Select FirstName  , LastName , Salary 
--from Employee
--where Department ='IT' and Salary > 5000;


--3. Find the highest salary from the Employees table.
--select MAX(Salary) as Salary From Employee


--Task 4
--1. Update the salary of John Doe to 55000.
--Update Employee
--set Salary = 50000
--where FirstName = 'John' AND LastName = 'Doe';


--2. Change the department of Jane Smith to Marketing.
--Update Employee
--set Department = 'Marketing'
--where FirstName = 'Jane' AND LastName = 'Smith';

--Task 5
--1. Delete the record of David Lee from the Employees table.
--Delete From Employee where FirstName = 'David' and LastName = 'Lee';


--2. Delete all employees in the Marketing department.
--Delete From Employee where FirstName = 'David' and LastName = 'Lee';

--Task 6
--1. Create a tabled named Products and insert below records in the table.
--create table products (
--productID int ,
--productName varchar(30),
--category varchar(40),
--Price int,
--Stock int);
--Insert into products 
--values(1, 'Laptop', 'Electronics', 1000, 50),
--(2,'Mouse', 'Electronics', 20, 200),
--(3,'Keyboard', 'Electronics', 30, 150),
--(4, 'Printer', 'Electronics', 150, 75);

--2. Select all columns from the Products table



--3. Select products, sorted by their price in descending order.
--select * from products
--order by Price Desc;

--4. Update the price of the "Mouse" to 25.
--update products
--set Price = 25
--where productName = 'Mouse';


--5. Delete the product with ProductID 2 (Mouse).
--Delete from products
--where productID = 2;

--6. Select products sorted by ProductName in alphabetical order.
--select * from products
--order by productName Asc;


--1. Create a tabled named Books with the below structure and insert below records in the
--table.
--create table books(
--bookID int, Title varchar(255),
--Author varchar(255), Publishedyear int,
--Availablecopies int);

--insert into books
--values (1, 'The Great Gatsby','F. Scott Fitzgerald', 1925,3),
--(2,'1984', 'George Orwell', 1949,2),
--(3, 'To Kill a Mockingbird','Harper Lee', 1960, 5),
--(4,'Brave New World','Aldous Huxley',1932,4);



--2. Update the available copies of "1984" to 5.
--update books
--set Availablecopies = 5
--where Title = '1984';

--select * from books 
--3. Delete the book with BookID 1 (The Great Gatsby).
--delete from books 
--where bookID = 1;

--4. Write a query to Select books published after 1950.
--select * from books 
--where Publishedyear > 1950


--Create a Customers table containing details about customers with the below details.
--create table Customers (
--customerid int,
--customername varchar(255),
--email varchar(255),
--phonenumber varchar(50));

--insert into Customers
--values(201, 'Alice Johnson','alice@example.com','555-1234'),
--(201,'Bob Smith', 'bob@example.com', '555-5678'),
--(203, 'Charlie Brown', 'charlie@example.com','555-8765');

--select * from Customers;

--2. Insert a new customer into the Customers table with the following details:
--a. CustomerID: 204
--b. CustomerName: David Wilson
--c. Email: david@example.com
--d. PhoneNumber: 555-4321
--insert into Customers
--values (204,'David Wilson','david@example.com','555-4321');

--3. Update the phone number of "Alice Johnson" to "555-9999"
--update Customers
--set phonenumber = '555-9999'
--where customername = 'Alice Johnson';

--4. Delete the customer with CustomerID 202 (Bob Smith
--delete from Customers 
--where customerid = 202


--TASK 9
--1. Create an Orders table that contains information about customer orders with the below
--details:

--create table orders (
--orderid int,
--customerid int,
--orderdate date,
--totalamount decimal(10,2));

--insert into orders 
--values (303, 201, '2024-09-02', 250.00),
--(302,202,' 2024-09-02 ',150.00), 
--(303,203,'2024-09-03',200.00);

--select * from orders;
--2. Insert a new order into the Orders table with the following details:
--a. OrderID: 304
--b. CustomerID: 204
--c. OrderDate: 2024-09-04
--d. TotalAmount: 300.00
--insert into orders 
--values (304,204,'2024-09-04', 300.00);


--3. Update the TotalAmount for OrderID 301 to 275.00.
--update orders
--set totalamount = 275.00
--where orderid = 301

--4. Delete the order with OrderID 302.
--delete from orders
--where orderid=302

--5. Select orders with a total amount greater than 200.
--select * from orders 
--where totalamount > 200

--6. Select only the OrderID and TotalAmount for all orders.
--select orderid , totalamount from orders


--TASK10
--Create a Students table with a StudentID as the primary key and include the following columns:
--FirstName, LastName, and Email. Insert three records into the table.
--Create table student (
--studntid int not null primary key,
--firstname varchar(25),
--lastname varchar(25),
--email varchar(25));
--insert into student
--values (1, 'John', 'Doe', 'john.doe@example.com'),
--(2, 'Jane', 'Smith', 'jane.smith@example.com'),
--(3, 'Mike', 'Johnson', 'mike.johnson@example.com');

--select * from student


--task11
--Create a Courses table with a CourseID as the primary key. Create a Enrollments table with a
--StudentID as a foreign key referencing the Students table and a CourseID as a foreign key
--referencing the Courses table. Insert sample data into both tables.
--create table courses (
--courseid int primary key,
--coursename varchar(25));

--insert into courses
--values (21, 'english'),
--(43, 'maths');

--select * from courses
--create table enrollment(
--enrollmenid int primary key,
--studntid int,
--courseid int,
--foreign key (studntid) references student(studntid),
--foreign key (courseid) references courses(courseid));

--insert into enrollment 
--values (987,2,21),
--(563, 1, 43),
--(245, 3, 43);
--select * from enrollment


--Assignment 12: Composite Key
--Task:
--Create an OrderDetails table that contains OrderID, ProductID, and Quantity. Define a
--composite primary key using OrderID and ProductID.

--create table OrderDetails (
--	OrderID int,
--	ProductID int,
--	Quantity int,
--	primary key (OrderID, ProductID)
--	);

---Assignment 13: Candidate Key and Alternate Key
--Task:
--Create a Users table with UserID as the primary key, and include Email and Username as
--candidate keys. Set the Email column as a unique key.

--CREATE TABLE Users (
--    UserID INT PRIMARY KEY,
--    Email VARCHAR(100) UNIQUE,
--    Username VARCHAR(50),
--    -- Candidate Key on Username
--    CONSTRAINT UC_Username UNIQUE (Username)
--);

--Assignment 14: Surrogate Key
--Task:
--Create a Products table with an AutoID as a surrogate key that automatically increments. Include
--ProductName and Price columns.

--create table Products1 (
--    AutoID int identity(1,1) primary key,
--    ProductName varchar(100),
--    Price decimal(10, 2)
--	);

--Assignment 15: Natural Key
--Task:
--Create a Employees table that uses SSN (Social Security Number) as a natural key. Include
--columns for FirstName, LastName, and Position.

--CREATE TABLE Employees1 (
--    SSN CHAR(11) PRIMARY KEY,  -- SSN formatted as "123-45-6789"
--    FirstName VARCHAR(50),
--    LastName VARCHAR(50),
--    Position VARCHAR(50)
--);

--INSERT INTO Employees1 (SSN, FirstName, LastName, Position) VALUES
--('123-45-6789', 'John', 'Doe', 'Software Engineer'),
--('987-65-4321', 'Jane', 'Smith', 'Data Analyst'),
--('456-78-9123', 'Mike', 'Johnson', 'Project Manager');

--Assignment 16: Unique Key
--Task:
--Create a Customers table with a CustomerID as the primary key and a PhoneNumber column
--that must be unique.

--create table Customers1 (
--    CustomerID int primary key,    
--    PhoneNumber varchar(15) unique
--);

--insert into Customers1 (CustomerID, PhoneNumber) values
--(1, '123-456-7890'),
--(2, '987-654-3210'),
--(3, '555-555-5555');

--select * from Customers1


--Assignment 17: Basic View Creation 
--Task: 
--1. Create a simple view named EmployeeView that displays the FirstName, LastName, and 
--Department columns from the Employees table.

--create view EmployeeView as
--select FirstName, LastName, Department
--From Employee ;

--select * from EmployeeView

--Assignment 18: Updating Data Through a View 
--Task: 
--1. Create a view named EditableEmployeeView that shows EmployeeID, FirstName, 
--LastName, and Salary. 
--2. Update the salary of an employee using the view. 
--3. Verify the update

--create view EditableEmployeeView 
--as
--select EmployeeID, FirstName, LastName, Salary
--From Employee

--select * from EditableEmployeeView

--Update EditableEmployeeView
--set Salary = 70000
--where EmployeeID=123

--select * from EditableEmployeeView

--Assignment 19: View with Calculated Columns 
--Task: 
--1. Create a view named EmployeeSalaryBonusView that displays each employee’s 
--FirstName, LastName, Salary, and a calculated column Bonus (10% of the salary). 
----2. Query the view

--Create view EmployeeSalaryBonusView
--as
--select
--FirstName,
--LastName,
--Salary ,
--Salary * 0.10 as Bonus
--from Employee

--select * from EmployeeSalaryBonusView

--Assignment 20: Altering a View 
--Task: 
--1. Alter the EmployeeView from Assignment 1 to include a new column Salary. 
--2. Verify the view with the updated column.
--Alter view EmployeeView
--as
--select FirstName , LastName, Department, Salary
--From Employee

--Select * From EmployeeView



--Assignment 21: View with Parameters (Simulated via Filters) 
--Task: 
--1. Create a view named FilteredEmployeeView from employees table that displays 
--EmployeeID,FirstName,LastName & Department. 
--2. Use a query on the view to return employees in a specific department (e.g., 
--DepartmentID = 2).
--Create view FilteredEmployeeView 
--as
--select EmployeeID,FirstName,LastName, Department
--From Employee

--select * From FilteredEmployeeView 
--Where Department = 'Marketing'

--Assignment 22: Dropping a View 
--Task: 
--1. Drop the EmployeeView that was created in the previous assignments. 
--2. Try to query the view again.
--Drop view EmployeeView

--Select * From EmployeeView
