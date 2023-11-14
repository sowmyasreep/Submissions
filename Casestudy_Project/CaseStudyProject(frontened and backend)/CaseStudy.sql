use Casestudy

-- Create a table to store student information 
CREATE TABLE Student (
    StudentID INT,
    Name NVARCHAR(25),
    DOB DATE,
    CONSTRAINT UQ_Student UNIQUE (StudentID, Name)
);

insert into Student values(1, 'Prasanna', '2000-07-20')
insert into Student values
(2,'Anusha','2001-3-20'),
(3,'Teja','2000-3-20'),
(4,'Rahul','2001-7-21'),
(5,'Kiran','2004-9-20')

select * from Student

 
 

-- Create a table to store course information with a composite key
CREATE TABLE Course (
    CourseID INT,
    CourseName NVARCHAR(255),
    CONSTRAINT UQ_Course UNIQUE (CourseID, CourseName)
);

insert into course values(101,'JAVA'),

(102,'Oracle'),

(103,'Dotnet'),

(104,'Artificial Inteligence'),

(105,'Cloud computing'),

(106,'HTML'),
(107,'Python');
 
 select * from Course



-- Create a table to store student registration information 
CREATE TABLE Register (
    StudentID INT,
    CourseID INT,
    RegistrationDate DATE,
    CONSTRAINT CK_Register UNIQUE (StudentID, CourseID)
);
 
 select * from Register



 




 
