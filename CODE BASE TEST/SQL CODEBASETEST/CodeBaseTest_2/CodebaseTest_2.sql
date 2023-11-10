use assignment2

create table Code_Employee(
 empno int primary key,
 empname varchar(35),
 empsal decimal(10,2) check (empsal >=25000),
 emptype char(1)
 );

 
CREATE or alter PROCEDURE  AddEmployee
   @empname varchar(45),
   @empsal numeric(10,3),
   @emptype char(1)
AS
BEGIN
   DECLARE @empno int;
 
   SELECT @empno = ISNULL(MAX(empno), 0) + 1 FROM Code_Employee;
 
   INSERT INTO Code_Employee (empno, empname, empsal, emptype)
   VALUES (@empno, @empname, @empsal, @emptype);
END;

use Assignment2
select * from Emp

declare @empno int
declare @sal int

-- Cursor Declaration
declare EmployeeCursor cursor for
select empno, sal
from Emp
where deptno = 10

 

-- Cursor open
open EmployeeCursor

 

--first row
fetch next from EmployeeCursor into @empno, @sal

-- Loop through the cursor
while @@fetch_status = 0
begin
set @sal = @sal * 1.15

-- Updating the salary with a 15% increase
update EMP
set sal = sal * 1.15
where EmpNo = @EmpNo

-- Fetching the next row
fetch next from EmployeeCursor into @empno, @sal
end

close EmployeeCursor
deallocate EmployeeCursor

-- Select the updated records to verify
select * from EMP where DeptNo = 10