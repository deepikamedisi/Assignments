use assignment2

create table Code_Employee(
 empno int primary key,
 empname varchar(35),
 empsal decimal(10,2) check (empsal >=25000),
 emptype char(1)
 );

create procedure AddNewEmployee(
    @empname varchar(25),
    @empsal decimal(10, 2),
    @emptype char(1)
)
as
begin
declare @new_empno int;
select @new_empno=isnull(max(empno),0)+1 from Code_Employee
insert into Code_Employee(empno, empname,empsal, emptype) values
(@new_empno, @empname, @empsal, @emptype)
select * from Code_Employee where empno=@new_empno
end
select *from Code_Employee

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