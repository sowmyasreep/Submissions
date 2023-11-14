use Assignments


--question1

declare @inputNumber int = 4; 
declare @factorial int = 1;
declare @counter int = 1;
while @counter <= @inputNumber

begin
    set @factorial = @factorial * @counter;
    set @counter = @counter + 1;
end
print 'Factorial of ' + cast(@inputNumber as nvarchar(10)) + ' is ' + cast(@factorial as nvarchar(10));



--question2 



create  procedure  GenerateMultiplicationTables(@maxNumber int)

as
begin
    declare @number int = 1;
    while @number <= @maxNumber
    begin
        declare @counter int = 1;
        while @counter <= 1
        begin
            print cast(@number as nvarchar(10)) + ' x ' + cast(@counter as nvarchar(10)) + ' = ' + cast(@number * @counter as nvarchar(10));
            set @counter = @counter + 1;
        end
        set @number = @number + 1
    end
end
EXEC GenerateMultiplicationTables @maxNumber = 2; -- Replace 5 with the desired maximum number



--question3

-- Create the holiday table
create table holiday (
holiday_date date primary key,
holiday_name varchar(40)
);

-- Insert some holiday data
INSERT INTO holiday (holiday_date, holiday_name)
values   ('2023-07-15', 'Independence_Day'),   ('2023-10-28', 'Diwali'),	('2023-01-26','Republic day');

create trigger trr on EMP

 after insert, update, delete as
 begin
 declare @holidayname varchar(20);
 select @holidayname = holiday_name from Holiday
 where holiday_date = convert(date, getdate());
 if @holidayname is not null
 begin
 declare @errormessage varchar(50);
 set @errormessage = 'Due To ' + @holidayname + ' You Cannot Manipulate Data';
 throw 51000, @errormessage, 1;
 end 
 end;


select * from Holiday;
 insert into Holiday values ('2023-12-25', 'Christmas');
update EMP set salary = 1400 where empno = 7934;




