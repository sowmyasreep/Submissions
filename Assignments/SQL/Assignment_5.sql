use Assignments
select * from EMP

create or alter procedure EMPPayslip (@empno INT)
as
begin
declare @SALARY decimal(10, 3)
declare @HRA decimal(10, 3)
declare @DA decimal(10, 3)
declare @PF decimal(10, 3)
declare @IT decimal(10, 3)
declare @DEDUCTIONS decimal(10, 3)
declare @GROSS_SALARY decimal(10, 3)
declare @NET_SALARY decimal(10, 3)


select @SALARY = Salary FROM EMP WHERE EMPNO = @EMPNO


select @HRA = @SALARY * 0.10

select @DA = @SALARY * 0.20

select @PF = @SALARY * 0.08

select @IT = @SALARY * 0.05

 

--Deductions as sum of PF and IT

select @DEDUCTIONS = @PF + @IT

 

--Gross Salary as sum of SAL,HRA,DA 

select @GROSS_SALARY = @SALARY + @HRA + @DA

 

--Net salary as  Gross salary- Deduction

select @NET_SALARY = @GROSS_SALARY - @DEDUCTIONS

 select @empno, ename, @SALARY as SALARY, @HRA as HRA, @DA as DA, @PF as PF, @IT as IT, @DEDUCTIONS as Deductions, @GROSS_SALARY as 'Gross Salary', @NET_SALARY AS 'NetSalary'
   from EMP
   where empno = @EMPNO

end

 
execute EMPPayslip @EMPNO = 7521