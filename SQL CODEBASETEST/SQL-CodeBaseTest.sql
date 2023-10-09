create database codebasetest
use codebasetest

   create table books
(
    id int primary key,
    title varchar(20),
    author varchar(20),
	isbn bigint,
	published_date datetime
)

insert into books(id,title,author,isbn,published_date)
values 
('1','My First SQL Book','Mary Parker','981483029127','2012-02-22 12:08:17'),
('2','My Second SQL Book','John Mayer','857300923713','1972-07-03 09:22:45'),
('3','My Third SQL Book','Cary Flint','523120967812','2015-10-18 14:05:44')

--1. Write a query to fetch the details of the books written by author whose name ends with er.

select * from books where author like '%[er]'

   create table reviews
(
   id int foreign key references books(id),
   book_id int ,
   Reviewer_name varchar(30),
   content varchar(40),
   rating int,
   Published_date datetime
 )

 insert into reviews (id,book_id,reviewer_name,content,rating,published_date)
 values
 (1,1,'John smith','My first review',4,'2017-12-10 05:50:11.1'),
 (2,2,'John smith','My second review',5,'2017-10-13 15:05:12.6'),
 (3,2,'Alice Walker','My Another review',1,'2017-10-22 23:47:10.1')

 --2.Display the Title ,Author and ReviewerName for all the books from the above table 

 select Title,Author ,Reviewer_Name from books join reviews on books.id=reviews.id


 --3.Display the  reviewer name who reviewed more than one book.

 select reviewer_name from reviews where content != 'My first review'

 
    create table Customer
( 
    Id int primary key,
	cust_name varchar(30),
	age int,
	cust_Address varchar(40),
	salary int
)

insert into Customer(id,cust_name, age, cust_address,salary) 
values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'kota',2000.00),
(4,'Chaitali',25,'mumbai',6500.00),
(5,'hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',4500.00),
(7,'Muffy',24,'Indore',10000.00)

  Create table orders
(
   OID int primary key ,
   Order_Date Date,
   Customer_Id int foreign key references customer(id),
   amount int
)

insert into orders (OID,Order_date,Customer_id,amount)
values
(102,'2009-10-08',3,3000),
(100,'2009-10-08',3,1500),
(101,'2009-11-20',2,1560),
(103,'2008-05-20',4,2060)

--4.Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address

Select cust_name From Customer where cust_Address LIKE '%o%';



--5.Write a query to display the   Date,Total no of customer  placed order on same Date 

select Order_Date, COUNT( Customer_Id) AS TotalCustomers from orders 
group by Order_Date


  create table Emp
( 
    Id int primary key,
	Emp_name varchar(30),
	age int,
	Emp_Address varchar(40),
	salary int
)

insert into Emp values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'kota',2000.00),
(4,'Chaitali',25,'mumbai',6500.00),
(5,'hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP' ,Null),
(7,'Muffy',24,'Indore' ,Null)

select * from Emp

--6.Display the Names of the Employee in lower case, whose salary is null 

select lower(Emp_name) as Employee_name,salary from Emp where salary is null 

   create table studentdetails
(
    register_id int,
   sname varchar(30),
   sage int,
   qual varchar(15),
   mobno bigint,
   mail varchar(30),
   loc varchar(20),
   gender varchar(20)

)
insert into  studentdetails values
(2,'sai',22,'B.E',9952836777,'sai@gmail.com','chennai','M'),
(3,'kumar',20,'BSC',7890125648,'kumar@gmail.com','chennai','M'),
(4,'selvi',22,'B.Tech',8904567342,'selvi@gmail.com','chennai','F'),
(5,'nisha',25,'M.E',7834672310,'nisha@gmail.com','chennai','F'),
(6,'saisaran',21,'B.A',7890345678,'saran@gmail.com','chennai','F'),
(7,'tom',23,'BCA',8901234675,'tom@gmail.com','chennai','M')

--7.Write a sql server query to display the Gender,Total no of male and female from the above relation.
                     
select gender, count(*) AS total_count from studentdetails group by gender