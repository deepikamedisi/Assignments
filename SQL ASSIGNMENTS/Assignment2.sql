create database Assignment2
use Assignment2

--create the table employee
Create table Emp (
    empno INT PRIMARY KEY,
    ename VARCHAR(30),
    job VARCHAR(25),
    mgr_id INT,
    hiredate DATE,
    sal int,
    comm int,
    deptno int
)

-- Create the DEPT table
Create table DEPT (
    deptno INT PRIMARY KEY,
    dname VARCHAR(20),
    loc VARCHAR(20)
)


-- Insert into employee table

insert into Emp values
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);

select * from Emp

--Insert into Dept table

insert into Dept values
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON');

select * from Dept

--1. List all employees whose name begins with 'A'.

select * from Emp where ename like 'A%'

--2. Select all those employees who don't have a manager.

select *from Emp where job like '[^m]%'

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 

select ename, empno,sal from Emp where sal between 1200 and 1400

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 

select * from Emp where deptno=20  
select Ename, sal, (sal*1.10) as Rise_in_Sal from Emp where deptno=20

--5. Find the number of CLERKS employed. Give it a descriptive heading. 

select count(job)  as 'Number of Clerks employed' from Emp  where job='clerk'

--6. Find the average salary for each job type and the number of people employed in each job. 

select job, Avg(sal) as Avg_salary ,Count(job) as NO_of_People from Emp Group by job

--7. List the employees with the lowest and highest salary. 

select * from emp where sal=(select max(sal) from emp) or sal=( select min(sal) from emp)

--8. List full details of departments that don't have any employees. 

select * from dept  where deptno not in (select deptno from emp)

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 

select ename ,sal from emp where job='analyst' and sal>1200 and deptno=20
order by ename desc

--10. For each department, list its name and number together with the total salary paid to employees in that department. 

select * from dept

select dname,dept.deptno ,sum (sal) as Total_sal from dept join emp on dept.deptno=emp.deptno group by dname ,dept.deptno

--11. Find out salary of both MILLER and SMITH.

select ename,sal  from emp where ename in ('miller','smith')

--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 

select ename from emp where ename like '[AM]%'

--13. Compute yearly salary of SMITH. 

select ename ,(sal*12) 'Yearly_salary' from emp where ename='smith'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 

select ename ,sal from emp where sal  not between 1500 and 2850

--15. Find all managers who have more than 2 employees reporting to them

Select e.mgr_id as Manager_id, m.ename as Manager_name, COUNT(*) AS employee_count
from Emp e
JOIN Emp m ON e.mgr_id = m.empno
group by e.mgr_id, m.ename
Having count(*) > 2;
