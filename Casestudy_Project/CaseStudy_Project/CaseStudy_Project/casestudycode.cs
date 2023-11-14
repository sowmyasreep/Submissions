using System;
using System.Collections.Generic;
using System.Linq;

public class Student

{

    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime DOB { get; set; }



    public Student(int id, string name, DateTime dob)

    {

        Id = id;

        Name = name;

        DOB = dob;

    }

}



class Info

{

    public void Display(Student student)
    {

        Console.WriteLine($"Student ID: {student.Id}");

        Console.WriteLine($"Student Name: {student.Name}");

        Console.WriteLine($"Date of Birth: {student.DOB}");

    }

    public void DisplayStudentDetails(Student student)
    {
        Console.WriteLine($"Student ID:{student.Id}, Name: {student.Name}, Date Of Birth: {student.DOB}");
    }

}



public class Course

{

    public int CourseId { get; set; }

    public string CourseName { get; set; }



    public Course(int courseId, string courseName)

    {

        CourseId = courseId;

        CourseName = courseName;

    }

}



public class Enroll

{

    private Student student;

    private Course course;

    private DateTime enrollmentDate;



    public Enroll(Student student, Course course, DateTime enrollmentDate)

    {

        this.student = student;

        this.course = course;

        this.enrollmentDate = enrollmentDate;

    }



    public Student GetStudent()

    {

        return student;

    }



    public Course GetCourse()

    {

        return course;

    }



    public DateTime GetEnrollmentDate()

    {

        return enrollmentDate;

    }

}



class AppEngine

{

    private List<Student> students = new List<Student>();

    private List<Course> courses = new List<Course>();

    private List<Enroll> enrollments = new List<Enroll>();



    public void Introduce(Course course)

    {

        courses.Add(course);

        Console.WriteLine($"New course introduced: {course.CourseName}");

    }



    public void Register(Student student)

    {

        students.Add(student);

        Console.WriteLine($"New student registered: {student.Name}");

    }



    public Student[] ListOfStudents()

    {

        return students.ToArray();

    }



    public Course[] ListOfCourses()

    {

        return courses.ToArray();

    }



    public void Enroll(Student student, Course course)

    {

        DateTime enrollmentDate = DateTime.Now; // You can set the enrollment date as needed

        Enroll enrollment = new Enroll(student, course, enrollmentDate);

        enrollments.Add(enrollment);

        Console.WriteLine($"Student {student.Name} enrolled in course {course.CourseName} on {enrollmentDate}");

    }



    public Enroll[] ListOfEnrollments()

    {

        return enrollments.ToArray();

    }

    public Student GetStudentById(int studentId)

    {

        return students.FirstOrDefault(student => student.Id == studentId);

    }



    public Course GetCourseById(int courseId)

    {

        return courses.FirstOrDefault(course => course.CourseId == courseId);

    }



}

abstract class UserInterface

{

    public abstract void showFirstScreen();

    public abstract void showStudentScreen();

    public abstract void showAdminScreen();

    public abstract void showAllStudentsScreen();

    public abstract void showStudentRegistrationScreen();

    public abstract void introduceNewCourseScreen();

    public abstract void showAllCoursesScreen();

}



class ConsoleUserInterface : UserInterface

{

    private AppEngine appEngine;



    public ConsoleUserInterface(AppEngine appEngine)

    {

        this.appEngine = appEngine;

    }



    public override void showFirstScreen()

    {
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");

        Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");

        Console.WriteLine("Enter your choice (1 or 2): ");

        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)

        {

            case 1:

                showStudentScreen();

                break;

            case 2:

                showAdminScreen();

                break;

            default:

                Console.WriteLine("Invalid choice.");

                break;

        }

    }



    public override void showStudentScreen()

    {

        Console.WriteLine("\n---------Student Menu:--------------");

        Console.WriteLine("1. View All Courses");

        Console.WriteLine("2. Back to Main Menu");

        Console.WriteLine("Enter your choice (1, or 2): ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)

        {

            case 1:

                showAllCoursesScreen();

                break;

            case 2:

                showFirstScreen();

                break;

            default:

                Console.WriteLine("Invalid choice.");

                break;

        }

    }



    public override void showAdminScreen()

    {

        Console.WriteLine("\n----------Admin Menu:-------------");

        Console.WriteLine("1. Introduce a New Course");

        Console.WriteLine("2. View All Students");

        Console.WriteLine("3. Register a Student");

        Console.WriteLine("4. Back to Main Menu");

        Console.WriteLine("Enter your choice (1, 2, or 3): ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)

        {

            case 1:

                introduceNewCourseScreen();

                break;

            case 2:

                showAllStudentsScreen();

                break;

            case 3:

                showStudentRegistrationScreen();

                break;

            case 4:

                showFirstScreen();

                break;

            default:

                Console.WriteLine("Invalid choice.");

                break;

        }

    }



    public override void showAllStudentsScreen()

    {

        Student[] students = appEngine.ListOfStudents();

        Console.WriteLine("List of Students:");

        foreach (var student in students)

        {

            Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}");

        }

        showAdminScreen();

    }



    public override void showStudentRegistrationScreen()

    {

        Console.WriteLine("Enter Student ID: ");

        int studentId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Course ID: ");

        int courseId = Convert.ToInt32(Console.ReadLine());

        Student student = appEngine.GetStudentById(studentId);

        Course course = appEngine.GetCourseById(courseId);

        if (student != null && course != null)

        {

            appEngine.Enroll(student, course);



        }

        else

        {

            Console.WriteLine("Invalid Student ID or Course ID.");

        }
        showAdminScreen();
    }



    public override void introduceNewCourseScreen()

    {

        Console.WriteLine("Enter Course ID: ");

        int courseId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Course Name: ");

        string courseName = Console.ReadLine();

        Course course = new Course(courseId, courseName);

        appEngine.Introduce(course);
        showAdminScreen();
    }



    public override void showAllCoursesScreen()

    {

        Course[] courses = appEngine.ListOfCourses();

        Console.WriteLine("List of Courses:");

        foreach (var course in courses)

        {

            Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");

        }
        showStudentScreen();
    }

}

class App

{

    static void Main(string[] args)

    {
        Info info = new Info();
        // Create an instance of AppEngine

        AppEngine appEngine = new AppEngine();



        // Scenario1: Create objects of the Student class and display them

        Scenario1();



        // Scenario2: Create an array of Student class and display them

        Scenario2();



        // Additional functionality:

        // Introduce a course
        Console.WriteLine("---------------------------------------------------------------------------");
        Course newCourse = new Course(101, "Python");
        Course newCourse1 = new Course(102, "SQL");
        Course newCourse2 = new Course(103, "C++");
        Course newCourse3 = new Course(104, "Java");
        Course newCourse4 = new Course(105, "Cloud Computing");
        Course newCourse5 = new Course(106, "Artificial Intelligence");
        Course newCourse6 = new Course(107,"Big Data");
        Course newCourse7 = new Course(108,"HTML");

       

        appEngine.Introduce(newCourse);
        appEngine.Introduce(newCourse1);
        appEngine.Introduce(newCourse2);
        appEngine.Introduce(newCourse3);
        appEngine.Introduce(newCourse4);
        appEngine.Introduce(newCourse5);
        appEngine.Introduce(newCourse6);
        appEngine.Introduce(newCourse7);



        // Register a student
        Console.WriteLine("------------------------------------------------------------------------");
        Student newStudent = new Student(4, "Kiran", new DateTime(2002, 9, 21));
        Student newStudent1 = new Student(5, "Amrutha", new DateTime(2002, 7, 06));
        Student newStudent2 = new Student(6, "Anjali", new DateTime(2000, 1, 12));
        Student newStudent3 = new Student(7, "Hemanth", new DateTime(2003, 7, 13));
        Student newStudent4 = new Student(8, "Kishore", new DateTime(2004, 9, 8));
        Student newStudent5 = new Student(9, "Ramya", new DateTime(2009, 2, 17));

        appEngine.Register(newStudent);
        appEngine.Register(newStudent1);
        appEngine.Register(newStudent2);
        appEngine.Register(newStudent3);
        appEngine.Register(newStudent4);
        appEngine.Register(newStudent5);

        Console.WriteLine("------------------------------------------------------------------------");

        // Enroll the student in a course

        appEngine.Enroll(newStudent, newCourse);
        appEngine.Enroll(newStudent1, newCourse3);
        appEngine.Enroll(newStudent2, newCourse5);
        appEngine.Enroll(newStudent3, newCourse3);
        appEngine.Enroll(newStudent2, newCourse5);
        appEngine.Enroll(newStudent4, newCourse5);


        Console.WriteLine("------------------------------------------------------------------------");

        // List students, courses, and enrollments

        Student[] studentList = appEngine.ListOfStudents();

        Course[] courseList = appEngine.ListOfCourses();

        Enroll[] enrollmentList = appEngine.ListOfEnrollments();



        Console.WriteLine("List of Students:");

        foreach (var student in studentList)

        {

            Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}");
            info.DisplayStudentDetails(student);
        }


        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("\nList of Courses:");

        foreach (var course in courseList)

        {

            Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");

        }


        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("\nList of Enrollments:");

        foreach (var enrollment in enrollmentList)

        {

            Student enrolledStudent = enrollment.GetStudent();

            Course enrolledCourse = enrollment.GetCourse();

            DateTime enrollmentDate = enrollment.GetEnrollmentDate();



            Console.WriteLine($"Student: {enrolledStudent.Name}, Course: {enrolledCourse.CourseName}, Enrollment Date: {enrollmentDate}");

        }


        ConsoleUserInterface userInterface = new ConsoleUserInterface(appEngine);



        // Create initial courses and students here...



        // Show the first screen of the user interface

        userInterface.showFirstScreen();
        Console.Read();
    }



    static void Scenario1()

    {
        Console.WriteLine("--------------------------Scenario-1---------------------------------");
        // Create objects of the Student class

        Student student1 = new Student(1, "Rajesh", new DateTime(2008, 2, 13));

        Student student2 = new Student(2, "Gowtham", new DateTime(2001, 7, 18));

        Student student3 = new Student(3, "Anand", new DateTime(2005, 3, 20));



        // Call the display method for each student

        Info info = new Info();

        info.Display(student1);

        info.Display(student2);

        info.Display(student3);

    }



    static void Scenario2()

    {
        Console.WriteLine("--------------------------Scenario-2----------------------------------");
        // Create an array of Student class and store objects in it

        Student[] students = new Student[3];

        students[0] = new Student(1, "Chaitanya", new DateTime(2020, 6, 21));

        students[1] = new Student(2, "Mahesh", new DateTime(2011,4, 5));

        students[2] = new Student(3, "Akhil", new DateTime(2017, 2, 2));



        // Create an Info object

        Info info = new Info();



        // Iterate over the array and call the display method for each student

        foreach (Student student in students)

        {

            info.Display(student);

        }

    }

}