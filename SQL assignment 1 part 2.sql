--Assignment 1: Sales Database
--Scenario:
--You are given a Sales table containing sales data for various products. The table structure is as
--follows:
--SaleID ProductID ProductName QuantitySold SaleAmount SaleDate
--1 101 Laptop 5 5000 2024-09-01
--2 102 Mouse 10 250 2024-09-02
--3 101 Laptop 3 3000 2024-09-03
--4 103 Keyboard 8 800 2024-09-04
--5 102 Mouse 6 150 2024-09-05
--Task:
--1. Write a query to calculate the total sales amount for all products (SUM).
--2. Write a query to find the maximum quantity sold of any product (MAX).
--3. Write a query to calculate the average sale amount per sale (AVG).
--4. Write a query to find the minimum sale amount in the database (MIN).
--5. Write a query to calculate the total quantity sold of a specific product, say "Laptop"
--(SUM with WHERE clause).

--create table Sales(
--saleID int,
--productID int,
--productName varchar(255),
--quantitySold int,
--saleAmount int,
--saleDate date);

--insert into Sales 
--values (1,101, 'Laptop' , 5 , 5000,  '2024-09-01'),
--(2, 102, ' Mouse' ,10 ,250, '2024-09-02'),
--(3, 101 , 'Laptop' , 3 ,3000 ,'2024-09-03'),
--(4 ,103, 'Keyboard', 8 ,800 ,'2024-09-04'),
--(5 ,102, 'Mouse' ,6 ,150 ,'2024-09-05');

--select * from Sales

--select sum(saleAmount) as totoalsale from Sales;

--select max(quantitySold) as maximum from Sales;

--select avg(saleAmount) as averagesaleamount
--from Sales;

--select min(saleAmount) as minimumsaleamount 
--from Sales

--select sum(quantitySold) as laptopsold 
--from Sales 
--where productName = 'Laptop';



--Assignment 2: Employee Salaries
--Scenario:

--You are given an Employees table with salary details. The table structure is as follows:
--EmployeeID EmployeeName Department Salary HireDate
--1 John Doe IT 5000 2022-01-10
--2 Jane Smith HR 6000 2021-03-15
--3 Bob Johnson Finance 5500 2020-06-20
--4 Alice Brown IT 6200 2023-02-01
--5 Charlie White Marketing 4800 2023-03-10
--Task:
--1. Write a query to find the total salary expenditure for all employees (SUM).
--2. Write a query to find the highest salary among all employees (MAX).
--3. Write a query to calculate the average salary across all employees (AVG).
--4. Write a query to find the minimum salary in the IT department (MIN with WHERE
--clause).
--5. Write a query to find the total number of employees in each department (COUNT and
--GROUP BY).

--create table Employees
--(employeeID int,
--employeeName varchar(255),
--department varchar(255),
--salary int,
--hireDate date);

--insert into Employees
--values (1 ,'John Doe' ,'IT ',5000 ,'2022-01-10'),
--(2,' Jane Smith ','HR', 6000 ,'2021-03-15'),
--(3 ,'Bob Johnson',' Finance', 5500 ,'2020-06-20'),
--(4,' Alice Brown',' IT', 6200, '2023-02-01'),
--(5,' Charlie White',' Marketing', 4800,' 2023-03-10');

--select * from Employees

--select sum(salary) as totalsalaryexpenditure
--from Employees;

--select max(salary) as highestsalary
--from Employee;

--select avg(salary)
--as averagesalary
--from Employees;

--select min(salary) 
--as minimumsalary 
--from Employees
--where department= 'IT';

--select department, count(employeeID) as totalemployee
--from Employees
--group by department;






--Assignment 3: Inventory Management
--Scenario:
--You are given an Inventory table with information about the stock levels of different products.
--The table structure is as follows:
--ProductID ProductName QuantityInStock ReorderLevel LastRestockDate
--201 Monitor 50 10 2024-08-25
--202 Printer 30 5 2024-09-01
--203 Mouse 100 15 2024-09-10
--204 Keyboard 80 20 2024-09-15
--205 Laptop 25 5 2024-09-20
--Task:
--1. Write a query to find the total quantity of products in stock (SUM).
--2. Write a query to find the product with the highest quantity in stock (MAX).
--3. Write a query to find the average reorder level across all products (AVG).
--4. Write a query to find the product with the lowest reorder level (MIN).
--5. Write a query to find the total quantity in stock for products where the quantity is
--less than the reorder level (SUM with WHERE clause).

--create table inventory
--(productID int,
--productName varchar(255),
--quantityinstock int,
--reorderlevel int,
--lastRestockDate Date);

--insert into inventory 
--values (201 ,'Monitor', 50 ,10 ,'2024-08-25'),
--(202,' Printer', 30, 5,' 2024-09-01'),
--(203,' Mouse', 100 ,15,' 2024-09-10'),
--(204,' Keyboard', 80 ,20,' 2024-09-15'),
--(205,'Laptop', 25, 5,' 2024-09-20');
--select * from inventory

--select sum(quantityinstock) 
--as totalquantity
--from inventory;

--SELECT  productName, quantityinstock
--FROM inventory
--WHERE quantityinstock = (SELECT MAX(quantityinstock) 
--FROM inventory);


--select avg(reorderlevel) 
--as avgofreorder
--from inventory;

--select min(reorderlevel) 
--as minimum
--from inventory;

--select sum(quantityinstock)
--as totalquantity
--from inventory
--where quantityinstock < reorderlevel ;


--Assignment 4: Customer Orders Database
--Scenario:
--You have a CustomerOrders table that contains details about customer orders. The structure of
--the table is as follows:
--OrderID CustomerID OrderDate OrderAmount QuantityOrdered
--501 C001 2024-09-10 1500 3
--502 C002 2024-09-11 2000 5
--503 C001 2024-09-12 1000 2
--504 C003 2024-09-13 2500 4
--505 C002 2024-09-14 3000 6

--Task:
--1. Write a query to calculate the total order amount for all orders (SUM).
--2. Write a query to find the average order amount for all customers (AVG).
--3. Write a query to find the maximum order amount from a single order (MAX).
--4. Write a query to find the total quantity ordered across all orders (SUM).
--5. Write a query to find the minimum order amount in the database (MIN).

--create table customerorders
--(orderid int, 
--customerid varchar(25),
--orderdate date,
--orderamount int,
--quantityordered int);

--insert into customerorders
--values (501,'C001','2024-09-10',1500 ,3),
--(502,'C002','2024-09-11', 2000 ,5),
--(503,'C001','2024-09-12', 1000, 2),
--(504,'C003','2024-09-13',2500,4),
--(505,'C002','2024-09-14',3000,6);
--select * from customerorders

--select sum(orderamount) as totalamount
--from customerorders;

--select avg(orderamount) as avgofamount 
--from customerorders;

--select max(orderamount) as maxamount
--from customerorders;

--select sum(quantityordered) as total_quantity
--from customerorders;

--select min(orderamount) 
--as minamount
--from customerorders;



--Assignment 6: Product Ratings Database
--Scenario:
--You have a ProductRatings table containing customer ratings for various products. The
--structure is as follows:
--RatingID ProductID CustomerID Rating ReviewDate
--1 P001 C001 4 2024-09-01
--2 P002 C002 5 2024-09-02
--3 P001 C003 3 2024-09-03
--4 P003 C001 2 2024-09-04
--5 P002 C004 4 2024-09-05

--Task:
--1. Write a query to calculate the average rating for each product (AVG with GROUP BY).
--2. Write a query to find the highest rating given to any product (MAX).
--3. Write a query to find the lowest rating given to any product (MIN).
--4. Write a query to find the total number of ratings for each product (COUNT and GROUP
--BY).
--5. Write a query to find the total number of products rated (COUNT with DISTINCT).

--create table productRating
--(ratingID int,
--productID varchar(255),
--customerID varchar(255),
--rating int,
--reviewDate date);

--insert into productRating
--values (1,'P001','C001', 4 ,'2024-09-01'),
--(2,'P002','C002', 5 ,'2024-09-02'),
--(3,'P001','C003',3 ,'2024-09-03'),
--(4,'P003','C001',2,'2024-09-04'),
--(5,'P002','C004',4,'2024-09-05');

--select * from productRating

--select avg(rating) as avg_rating
--from productRating

--select max(rating)
--as max_rating
--from productRating;

--select min(rating)
--as min_rating
--from productRating;

--select productID, count(rating)
--as total_no_of_rating
--from productRating
--group by productID;

--select count(distinct productID)
--as total_distinct_product
--from productRating;

-----------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------

--SQL Server assignments and solutions using various SQL operators such as IN,
--BETWEEN, LIKE, AND, OR, NOT, etc.

--Assignment 1:
--Retrieve Employees Who Work in Specific Departments Using IN Operator
--Task: Retrieve the names of employees who work in either the 'HR', 'Finance', or 'IT'
--departments.
--Tables:
--Employees (EmployeeID, EmployeeName, DepartmentID)

--select employeeName 
--from Employees 
--where department in ('HR' , 'Finance' ,'IT');


--Assignment 2:
--Retrieve Products Within a Specific Price Range Using BETWEEN Operator
--Task: Retrieve the product names and prices of products that are priced between 100 and 500.
--Tables:
--Products (ProductID, ProductName, Price)

--select productName, Price 
--from products 
--where price between 100 and 500;

--Assignment 3:
--Find Customers Whose Name Starts With 'A' Using LIKE Operator
--Task: Retrieve the customer names that start with the letter 'A'.
--Tables:
--Customers (CustomerID, CustomerName)

--select customername 
--from customers 
--where customername like 'A%' 


--Assignment 4:
--Retrieve Orders Placed on Specific Dates Using IN Operator
--Task: Retrieve the order IDs of orders placed on '2023-01-01', '2023-02-01', and '2023-03-01'.
--Tables:
--Orders (OrderID, OrderDate)

--select orderid from customerorders 
--where orderdate in ( '2023-01-01' , '2023-02-01' , '2023-03-01');


--Assignment 5:
--Retrieve Products That Are Not Priced Between 100 and 500 Using NOT BETWEEN
--Operator
--Task: Retrieve the product names and prices of products that are not priced between 100 and
--500.

--select productName, Price 
--from products 
--where price not between 100 and 500;

--Assignment 6:
--Find Orders Where the Total Amount is More Than 5000 or Less Than 1000 Using OR
--Operator
--Task: Retrieve the order IDs where the total amount is either greater than 5000 or less than 1000.

--select orderid 
--from orders
--where totalamount > 5000
--OR totalamount < 1000;

--Assignment 7:
--Retrieve Employees Who Do Not Work in the 'HR' or 'IT' Departments Using NOT IN
--Operator
--Task: Retrieve the names of employees who do not work in the 'HR' or 'IT' departments.
--Tables:
--Employees (EmployeeID, EmployeeName, DepartmentID)

--select employeeName 
--from Employees
--where department not in ('HR','IT');

--Assignment 8:
--Retrieve Orders Placed in 2023 Using BETWEEN and AND Operators
--Task: Retrieve the order IDs of orders placed between '2023-01-01' and '2023-12-31'.
--Tables:
--Orders (OrderID, OrderDate)

--select orderid
--from orders
--where orderdate between '2024-01-01' and '2024-12-31';

--Assignment 9:
--Find Customers Who Do Not Have 'John' in Their Name Using NOT LIKE Operator
--Task: Retrieve the customer names that do not have 'John' in them.
--Tables:
--Customers (CustomerID, CustomerName)

--select customername
--from Customers
--where customername not like '%John%';


--Assignment 10:
--Retrieve Products That Are Either in Category 'A' or Priced Below 100 Using IN and OR
--Operators
--Task: Retrieve the product names and prices of products that are either in category 'A' or have a
--price less than 100.
--Tables:
--Products (ProductID, ProductName, Price, CategoryID)
--Categories (CategoryID, CategoryName)

--SELECT productName, Price
--FROM products
--WHERE category IN ('a') OR price < 100;

---------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------

--SQL Server assignments focused on using the ALTER TABLE 
--command to perform various table modifications. 
--Assignment 1: Add a New Column 
--Task: Add a column DateOfBirth (data type DATE) to the Employees table to store employees' 
--dates of birth. 

--alter table Employees
--add DateofBirth date;

--insert into Employees
--values (1 ,'John Doe' ,'IT ',5000 ,'2022-01-10','2002-11-21'),
--(2,' Jane Smith ','HR', 6000 ,'2021-03-15','1998-06-21'),
--(3 ,'Bob Johnson',' Finance', 5500 ,'2020-06-20','2001-05-03'),
--(4,' Alice Brown',' IT', 6200, '2023-02-01','1997-07-17'),
--(5,' Charlie White',' Marketing', 4800,' 2023-03-10','2003-03-27');
--select * from Employees


--Assignment 2: Modify Column Data Type 
--Task: Change the data type of the PhoneNumber column in the Customers table to 
--VARCHAR(15).

--alter table Customers
--Alter column phonenumber varchar(15);

--Assignment 3: Add a Primary Key 
--Task: Add a primary key to the DepartmentID column in the Departments table.
--create table Department
--(Department_id int,
--Department_name varchar(20));

--alter table Department
--add constraint pk_Department primary key (Department_id);

--Assignment 4: Drop a Column 
--Task: Remove the MiddleName column from the Employees table.
--alter table Employees
--add Middlename varchar(20);

--alter table Employees
--drop column Middlename

--select * from Employees

--Assignment 5: Add a Foreign Key 
--Task: Add a foreign key to the customerID column in the Orders table that references the 
--customerID column in the customers table.
--alter table orders
--add constraint fk_orders_Customers
--foreign key (customerid)
--references Customers(customerid);

--Assignment 6: Drop a Foreign Key 
--Task: Remove the foreign key constraint that references EmployeeID from the Orders table.
--alter table orders
--drop constraint fk_orders_Customers

--Assignment 7: Rename a Column 
--Task: Rename the column FullName to EmployeeFullName in the Employees table. 

--exec sp_rename 'Employees.fullname',
--'employeefullname','column'


--Assignment 8: Add a Default Value 
--Task: Add a default value of 'Active' to the Status column in the Employees table.
--alter table Employees
--add Status varchar(25);
--insert into Employees
--values (1 ,'John Doe' ,'IT ',5000 ,'2022-01-10','2005-02-04',default);

--alter table Employees
--add constraint DF_Status default 'active' for Status;
--select * from Employees

--Assignment 9: Drop a Primary Key 
--Task: Drop the primary key constraint from the Departments table.

--alter table Department
--drop constraint pk_Department;

--Assignment 10: Add a Unique Constraint 
--Task: Ensure the Email column in the Employees table is unique by adding a unique constraint.

--alter table Employee
--add email varchar(30) ;

--alter table Employee
--alter email
--drop default;

--alter table Employee
--add constraint uq_email unique(email);



--Assignment 11: Add a Check Constraint 
--Task: Add a check constraint to the Salary column in the Employees table to ensure that no 
--salary is less than 1000

--ALTER TABLE Employees
--ADD CONSTRAINT chk_salary
--CHECK (salary >= 1000);

--Assignment 13: Drop a Check Constraint 
--Task: Remove the check constraint from the Salary column in the Employees table.

--ALTER TABLE employees
--DROP CONSTRAINT chk_salary;

------------------------------------------------------------------------------------------------------------------------------==============================
----==============================================================================================================================================================

--SQL Server assignments involving subqueries. 
--Assignment 1:  
--Retrieve Employees Who Earn More Than the Average Salary 
--Task: Retrieve the names and salaries of employees whose salary is greater than the average 
--salary of all employees in the company. 
--Tables: 
--Employees (EmployeeID, EmployeeName, Salary)

--select employeefullname, employeeID, salary 
--from Employees 
--where salary > (select avg(salary) from Employees);

--Assignment 2:  
--Find Departments with More Than 5 Employees 
--Task: Retrieve the department names that have more than 5 employees. 
--Tables: 
--Employees (EmployeeID, EmployeeName, DepartmentID) 



--select distinct department_id
--from Employees
--where department_id in(select department_id
--from Employee group by department_id having count(department_id) > 5);

--Assignment 3:  
--Retrieve Products with a Price Higher Than the Maximum Price of Category 'A' 
--Task: Retrieve the product names and prices of products that have a price higher than the 
--maximum price of products in category 'A'. 
--Tables: 
--Products (ProductID, ProductName, Price, CategoryID)

--select productName , Price
--from products
--where price > (select max(Price) 
--from products
--where category = 'A');


--Assignment 4:  
--Retrieve Employees Who Work in Departments with Average Salary Higher Than 50,000 
--Task: Retrieve the names of employees who work in departments where the average salary is 
--higher than 50,000. 
--Tables: 
--Employees (EmployeeID, EmployeeName, Salary, DepartmentID) 
--Departments (DepartmentID, DepartmentName)

--alter table Employees
--add constraint fk_department_id
--foreign key (department_id)
--references Department(Department_id);

--select employeefullname 
--from Employees
--where department_id in (
--select department_id 
--from Employees 
--group by department_id
--having avg(salary)>50000);


--Assignment 5: Find Employees Who Earn More Than Their Departments 
--Average Salary Task: Retrieve the names of employees who earn more
--than the average salary of their department. 
--Tables: Employees (EmployeeID, EmployeeName, Salary, DepartmentID)

--SELECT employeefullname
--FROM Employees e
--WHERE salary > (
--SELECT AVG(salary)
--FROM Employees
--WHERE department_id = e.department_id);

--Assignment 6:  
--Find Customers Who Have Not Placed Any Orders 
--Task: Retrieve the names of customers who have not placed any orders. 
--Tables: 
--Customers (CustomerID, CustomerName) 

--select customername 
--from Customers  
--where customerid not in (
--select distinct customerid
--from orders);

--Assignment 7:  
--Retrieve Top 3 Highest-Paid Employees in Each Department 
--Task: Retrieve the top 3 highest-paid employees in each department. 
--Tables: 
--Employees (EmployeeID, EmployeeName, Salary, DepartmentID)

--select employeefullname
--from Employees
--where (select max(salary) , distinct department
--from Employees);

--Assignment 8:  
--Find Products That Have Never Been Ordered 
--Task: Retrieve the names of products that have never been ordered. 
--Tables: 
--Products (ProductID, ProductName) 
--OrderDetails (OrderID, ProductID)

--select productName 
--from products
--where productID not in (
--select distinct productID 
--from OrderDetails );

----========================================================================================================
--=====================================================================================================================

--Assignment 1:  
--Retrieve Employees and Their Department Names (INNER JOIN) 
--Task: Retrieve the employee names and their corresponding department names. 
--Tables: 
--Employees (EmployeeID, EmployeeName, DepartmentID) 
--Departments (DepartmentID, DepartmentName)

--select Employees.employeefullname, Department.Department_name
--from Employees inner join Department 
--on Employees.department_id = Department.Department_id;


--Assignment 2:  
--Retrieve All Employees and Their Department Names, Including Those Without 
--Departments (LEFT JOIN) 
--Task: Retrieve the employee names and their corresponding department names. Include 
--employees who are not assigned to any department. 
--Tables: 
--Employees (EmployeeID, EmployeeName, DepartmentID)

--SELECT e.employeefullname, d.Department_name
--FROM Employees e
--LEFT JOIN Department d ON e.department_id = d.Department_id;


--Assignment 3:  
--Retrieve All Departments and the Employees Working in Them (RIGHT JOIN) 
--Task: Retrieve all departments and their respective employees. Include departments even if they 
--don’t have any employees. 
--Tables: 
--Employees (EmployeeID, EmployeeName, DepartmentID)

--select d.Department_id,d.Department_name, e.employeefullname
--from Employees e RIGHT JOIN Department d
--on e.department_id=d.Department_id;

--Assignment 4:  
--Retrieve All Employees and Departments, Including Those Without Matches (FULL 
--OUTER JOIN) 
--Task: Retrieve all employees and all departments, including employees without a department 
--and departments without employees. 
--Tables: 
--Employees (EmployeeID, EmployeeName, DepartmentID) 
--Departments (DepartmentID, DepartmentName)

--select e.employeefullname,e.employeeID,d.Department_name, d.Department_id 
--from Employees e full outer join Department d 
--on e.department_id = d.Department_id;

--Assignment 5:  
--Retrieve Orders and the Customers Who Placed Them (INNER JOIN) 
--Task: Retrieve order IDs and customer names for all orders. 
--Tables: 
--Orders (OrderID, CustomerID)

--select o.orderid, c.customername
--from orders o inner join Customers c
--on o.customerid = c.customerid;

--Assignment 6:  
--Retrieve Orders and Customers, Including Customers Without Orders (LEFT JOIN) 
--Task: Retrieve all customers and their respective orders. Include customers even if they haven’t 
--placed any orders. 
--Tables: 
--Orders (OrderID, CustomerID) 
--Customers (CustomerID, CustomerName)

--select  c.customername , c.customerid, o.orderid
--from customers c left join orders o
--on o.customerid = c.customerid;

--Assignment 7:  
--Retrieve Products and Their Categories (INNER JOIN) 
--Task: Retrieve product names and their respective category names. 
--Tables: 
--Products (ProductID, ProductName, CategoryID)

--create table categories
--(category varchar(40),
--category_id int primary key);

--select ct.category , p.productName
--from categories ct inner join products p
--on ct.category_id=p.category_id;

--Assignment 8:  
--Retrieve All Categories and Products, Including Categories Without Products (RIGHT 
--JOIN) 
--Task: Retrieve all categories and the products in each category. Include categories that don’t 
--have any products. 
--Tables: 
--Products (ProductID, ProductName, CategoryID) 
--Categories (CategoryID, CategoryName)

--select ct.category_id, ct.category , p.productName
--from products p Right join categories ct 
--on p.category_id=ct.category_id;

--Assignment 9:  
--Retrieve Employees and Their Managers (Self-Join) 
--Task: Retrieve the employee names and the names of their managers. 
--Tables: 
--Employees (EmployeeID, EmployeeName, ManagerID)

--select e.employeefullname as employee, m.employeefullname as manager
--from Employees e
--inner join Employees m on e.manager_id = m.employeeID;

--Assignment 10:  
--Get All Possible Combinations of Products and Orders (CROSS JOIN) 
--Task: Retrieve all possible combinations of products and orders (cartesian product). 
--Tables: 
--Products (ProductID, ProductName) 
--Orders (OrderID)

--select p.productID, p.productName, o.orderid
--from products p cross join orders o ;

------============================================================================================================================================================
------=================================================================================================================================================================
--SQL Server assignments using the GROUP BY and HAVING clauses 
--Assignment 1:  
--Find the Average Salary in Each Department 
--Task: Retrieve the department name and the average salary of employees in each department. 
--Only display departments where the average salary is greater than 50,000. 
--Tables: 

--SELECT d.Department_name, AVG(e.salary) AS AverageSalary
--FROM Employees e
--JOIN Department d ON e.department_id = d.Department_id
--GROUP BY d.Department_name
--HAVING AVG(e.Salary) > 50000;

--Assignment 2:  
--Count the Number of Employees in Each Department 
--Task: Retrieve the department name and the total number of employees in each department. 
--Only display departments that have more than 5 employees. 
--Tables: 
--Employees (EmployeeID, EmployeeName, DepartmentID)

--select Department, count(employeeID) as totolEmployees
--from Employees
--group by department
--having count(employeeID) > 5;

--Assignment 3:  
--Find the Maximum and Minimum Salary in Each Department 
--Task: Retrieve the department name, maximum salary, and minimum salary for each 
--department. Only include departments where the minimum salary is greater than 30,000. 
--Tables: 
--Employees (EmployeeID, EmployeeName, Salary, DepartmentID)

--select department , min(salary) as minimum_salary, max(salary) as max_salary
--from Employees
--group by department
--having min(salary)>30000;

--Assignment 4:  
--Find the Total Sales by Each Salesperson 
--Task: Retrieve the employee name and total sales made by each salesperson. Only display 
--salespersons who have made total sales of more than 100,000. 
--Tables: 
--Sales (SalesID, EmployeeID, Amount)

--create table salesperson
--(sale_id int,
--employeename varchar(50),
--);

--insert into salesperson
--values ( 1,'zeba'),(2,'naja'),(3,'zeba'),(4,'zeba'),(5,'naja');

--select* from salesperson

--select employeename , sum(saleAmount) as total_sales
--from salesperson sp
--join sales s on s.saleID= sp.sale_id
--group by employeename
--having sum(saleAmount) > 10000;



--Assignment 5:  
--Find the Number of Orders by Each Customer 
--Task: Retrieve the customer name and the total number of orders placed by each customer. Only 
--display customers who have placed more than 3 orders. 
--Tables: 
--Orders (OrderID, CustomerID) 
--Customers (CustomerID, CustomerName)

--select customername, count(orderid) as total_orders
--from Customers c
--join orders o on c.customerid = o.customerid
--group by customername
--having count(orderid)>3;

