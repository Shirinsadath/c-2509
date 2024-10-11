--create table Customer
--(customer_ID int primary key,
--Name varchar(255),
--address varchar(255),
--phone varchar(20),
--Email varchar(100));

--insert into Customer
--values (21, 'Shirin Sadath', '123 main road idukki','9875641897','shirinsadath@gmail.com'),
--(22,'Zeba','233 westhill','9633881177','zeba@gamil.com');

--select * from Customer;

--create table Account
--(customer_ID int,
--Account_no int primary key,
--Account_type varchar(10),
--Balance Decimal(10,2),
--opendate date,
--foreign key (customer_ID) references
--Customer(customer_ID));

--insert into Account
--values (22,9831254, 'savings', 502.05,'2023-11-03');

--select * from Account;

--create table Loan
--(customer_ID int,
--Loan_ID int primary key,
--Loan_type varchar(10),
--Amount int,
--Interest_rate Decimal(10,1),
--openedDate date,
--foreign key (customer_ID) references
--Customer(customer_ID));

--insert into Loan 
--values (21, 233, 'home', 100000, 3.5, '2022-01-23'),
--(22,245,'car', 80000, 2.5, '2021-03-12');

--select * from Loan;

--create table Cards
--(customer_ID int ,
--card_no int primary key,
--card_type varchar(10),
--cvv int,
--expirydate date,
--foreign key (customer_ID ) references
--Customer (customer_ID));

--insert into Cards 
--values (21, 1276345, 'Debit', 233, '2025-05-04'),
--(22, 6859042, 'Credir', 547, '2026-01-30');

--insert into Cards 
--values (21, 2357854, 'credit', 124, '2025-06-09');

--select * from Cards

--create table Loan_Type
--(Loan_ID int primary key,
--Loan_Type varchar(25) );

--JOINS

--CREATE TABLE Student ( id int PRIMARY KEY
--IDENTITY,
--admission_no varchar(45) NOT NULL,
--first_name varchar(45) NOT NULL,
--last_name varchar(45) NOT NULL, age int,
--city varchar(25) NOT NULL
--);

--insert into Student 
--values ( 6252, 'shirin', 'sadath', 22, 'vadakara'),
--( 6253,'zaman','sadath',18,'kozhikode'),
--(6254,'rehaan','sadath',14,'thalassery');

--select * from Student

--CREATE TABLE Fee (
--admissionno varchar(45) NOT NULL,
--course varchar(45) NOT NULL,
--amount_paid int);

--insert into Fee 
--values (6252, 'Cloud computing', 30000),
--(6253, 'Data Analytics', 35000),
--(6254 , 'Mearn stack',32000);

--select * from Fee

--select Student.first_name , Fee.amount_paid
--from Student inner join Fee 
--on Student.admission_no = Fee.admission_no;

--select Student.first_name , Student.last_name,Fee.amount_paid
--from Fee right outer join Student 
--on Student.admission_no = Fee.admission_no;


--create table employeemanager
--(employeeid int primary key,
--employeename varchar(25),
--managerid int)

--insert into employeemanager
--values (1,'Ravi',NULL),
--(2,'Raj' , 4),
--(3,'Sachin', 2),
--(4,'Sajin',1);

select * from employeemanager

select e1.employeename, 




