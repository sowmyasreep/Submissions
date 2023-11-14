

using System;

using System.Collections.Generic;

using System.Linq;

using static System.Console;

using System.Data;

using System.Data.SqlClient;

class Program

{

    public static SqlConnection con;

    public static SqlDataReader dr;

    public static SqlCommand cmd;

    static SqlConnection Getconnection()

    {

        con = new SqlConnection("Data Source=ICS-LT-HHK96V3;Initial Catalog=Casestudy;" +

            "integrated Security=true");

        con.Open();

        return con;

    }

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

            WriteLine($"Student ID: {student.Id}");

            WriteLine($"Student Name: {student.Name}");

            WriteLine($"Date of Birth: {student.DOB}");

        }

        public void DisplayStudentDetails(Student student)

        {

            WriteLine($"Student ID:{student.Id}, Name: {student.Name}, Date Of Birth: {student.DOB}");

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

            WriteLine($"New course introduced: {course.CourseName}");

        }

        public void Register(Student Register)

        {

            con = Getconnection();

            students.Add(Register);

        }

        public Student[] ListOfStudents()

        {

            con = Getconnection();

            return students.ToArray();

        }

        public Course[] ListOfCourses()

        {

            con = Getconnection();

            return courses.ToArray();

        }

        public void Enroll(Student student, Course course)

        {

            con = Getconnection();

            DateTime enrollmentDate = DateTime.Now; 

            Enroll enrollment = new Enroll(student, course, enrollmentDate);

            enrollments.Add(enrollment);

            WriteLine($"Student {student.Name} enrolled in course {course.CourseName} on {enrollmentDate}");

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

            WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");

            WriteLine("Tell us who you are : \n1. Student\n2. Admin");

            WriteLine("Enter your choice (1 or 2): ");

            int op = Convert.ToInt32(ReadLine());

            switch (op)

            {

                case 1:

                    showStudentScreen();

                    break;

                case 2:

                    showAdminScreen();

                    break;

                default:

                    WriteLine("Invalid choice.");

                    break;

            }

        }

        public override void showStudentScreen()

        {

            WriteLine("\nStudent Menu:");

            WriteLine("1. View All Courses");

            WriteLine("2. Back to Main Menu");

            WriteLine("Enter your choice (1, or 2): ");

            int choice = Convert.ToInt32(ReadLine());

            switch (choice)

            {

                case 1:

                    showAllCoursesScreen();

                    break;

                case 2:

                    showFirstScreen();

                    break;

                default:

                    WriteLine("Invalid choice.");

                    break;

            }

        }

        public override void showAdminScreen()

        {

            WriteLine("\nAdmin Menu:");

            WriteLine("1. Introduce a New Course");

            WriteLine("2. ADD a Students");

            WriteLine("3. Register a Student");

            WriteLine("4. Back to Main Menu");

            WriteLine("Enter your choice (1, 2, or 3): ");

            int choice = Convert.ToInt32(ReadLine());

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

                    WriteLine("Invalid choice.");

                    break;

            }

        }

        public override void showAllStudentsScreen()

        {

            con = Getconnection();

            try

            {

                int StudentID;

                string Name;

                DateTime DOB;

                Console.WriteLine("Please Enter StudentID:");

                StudentID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter  name :");

                Name = Convert.ToString(ReadLine());

                Console.WriteLine("Please Enter  dob :");

                DOB = Convert.ToDateTime(ReadLine());

                cmd = new SqlCommand("insert into  student values(@sid,@Name,@DOB)", con);

                cmd.Parameters.AddWithValue("@sid", StudentID);

                cmd.Parameters.AddWithValue("@Name", Name);

                cmd.Parameters.AddWithValue("@DOB", DOB);

                int res = cmd.ExecuteNonQuery();


                if (res > 0)

                    Console.WriteLine("\n*****Student added successfully*****");

                else

                    Console.WriteLine("\n****Oops!! Student not added****");

            }

            catch (SqlException se)

            {

                Console.WriteLine(se.Message);

            }


            showAdminScreen();

        }

        public override void showStudentRegistrationScreen()

        {

            try

            {

                int StudentID, CourseID;

                DateTime RegistrationDate;

                Console.WriteLine("Please Enter StudentID:");

                StudentID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter  CourseID :");

                CourseID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter  RegistrationDate :");

                RegistrationDate = Convert.ToDateTime(ReadLine());

                cmd = new SqlCommand("insert into  register values(@sid,@cid,@rdate)", con);

                cmd.Parameters.AddWithValue("@sid", StudentID);

                cmd.Parameters.AddWithValue("@cid", CourseID);

                cmd.Parameters.AddWithValue("@rdate", RegistrationDate);

                int res = cmd.ExecuteNonQuery();


                if (res > 0)

                    Console.WriteLine("\n****Registration successfull****");

                else

                    Console.WriteLine("\n***Oops!!! Registration not successfull***");

            }

            catch (SqlException se)

            {

                Console.WriteLine(se.Message);

            }

            showAdminScreen();

        }

        public override void introduceNewCourseScreen()

        {

            try

            {

                int CourseID;

                string CourseName;

                Console.WriteLine("Please Enter CourseID:");

                CourseID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter CourseName  :");

                CourseName = Convert.ToString(Console.ReadLine());


                cmd = new SqlCommand("insert into  Course values(@cid,@cname)", con);

                cmd.Parameters.AddWithValue("@cid", CourseID);

                cmd.Parameters.AddWithValue("@cname", CourseName);

                {

                    int res = cmd.ExecuteNonQuery();


                    if (res > 0)

                        Console.WriteLine("\n*****course added successfully*****");

                    else

                        Console.WriteLine(" \n** Not added,Please try again**");

                }

            }

            catch (SqlException se)

            {

                Console.WriteLine(se.Message);

            }

            showAdminScreen();




        }

        public override void showAllCoursesScreen()

        {

            con = Getconnection();

            cmd = new SqlCommand("select * from Course");

            cmd.Connection = con;

            dr = cmd.ExecuteReader();

            while (dr.Read())

            {

                

                Console.WriteLine("CourseId :" + " " + dr[0]);

                Console.WriteLine("CourseName :" + " " + dr[1]);

                Console.WriteLine("------------------------------------------");

            }

            showStudentScreen();

        }

    }

    class App

    {

        public static SqlConnection con;

        public static SqlCommand cmd;

        public static SqlDataReader dr;

        static void Main(string[] args)

        {

            Info info = new Info();

            // Create an instance of AppEngine

            AppEngine appEngine = new AppEngine();

            // Scenario1: Create objects of the Student class and display them

            Scenario1();

            //

            // Scenario2: Create an array of Student class and display them

            Scenario2();

            WriteLine("-------------------------------------------------------------------------------------");

            // Introduce a course

            Course newCourse = new Course(101, "Java");

            Course newCourse1 = new Course(102, "Oracle");

            Course newCourse2 = new Course(103, "DotNet");

            Course newCourse3 = new Course(104, "Artificial Intelligence");

            Course newCourse4 = new Course(105, "Cloud Computing");

            Course newCourse5 = new Course(106, "HTML");
            Course newCourse6 = new Course(106, "Python");

            appEngine.Introduce(newCourse);

            appEngine.Introduce(newCourse1);

            appEngine.Introduce(newCourse2);

            appEngine.Introduce(newCourse3);

            appEngine.Introduce(newCourse4);

            appEngine.Introduce(newCourse5);
            appEngine.Introduce(newCourse6);

            WriteLine("----------------------------------------------------------------------------------------");

            // Register a student

            Student newStudent = new Student(4, "Sana", new DateTime(2000, 7, 20));

            Student newStudent1 = new Student(5, "Nikki", new DateTime(2001, 3, 20));

            Student newStudent2 = new Student(6, "Joshua", new DateTime(2000, 8, 17));

            Student newStudent3 = new Student(7, "Dino", new DateTime(2001, 7, 21));

            Student newStudent4 = new Student(8, "Jin", new DateTime(2004, 9, 20));

            Student newStudent5 = new Student(9, "Anusha", new DateTime(2009, 7, 23));

            WriteLine("----------------------------------------------------------------------------------------");

            appEngine.Register(newStudent);

            appEngine.Register(newStudent1);

            appEngine.Register(newStudent2);

            appEngine.Register(newStudent3);

            appEngine.Register(newStudent4);

            appEngine.Register(newStudent5);

            WriteLine("---------------------------------------------------------------------------------------------");

            // Enroll the student in a course

            appEngine.Enroll(newStudent, newCourse);

            appEngine.Enroll(newStudent1, newCourse3);

            appEngine.Enroll(newStudent2, newCourse5);

            appEngine.Enroll(newStudent3, newCourse3);

            appEngine.Enroll(newStudent2, newCourse5);

            appEngine.Enroll(newStudent4, newCourse5);

            WriteLine("----------------------------------------------------------------------------------------------");

            // List students, courses, and enrollments

            Student[] studentList = appEngine.ListOfStudents();

            Course[] courseList = appEngine.ListOfCourses();

            Enroll[] enrollmentList = appEngine.ListOfEnrollments();

            WriteLine("List of Students:");

            foreach (var student in studentList)

            {

                WriteLine($"Student ID: {student.Id}, Name: {student.Name}");

                info.DisplayStudentDetails(student);

            }

            WriteLine("\nList of Courses:");

            foreach (var course in courseList)

            {

                WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");

            }

            WriteLine("------------------------------------------------------------------------------------------------");

            WriteLine("\nList of Enrollments:");

            foreach (var enrollment in enrollmentList)

            {

                Student enrolledStudent = enrollment.GetStudent();

                Course enrolledCourse = enrollment.GetCourse();

                DateTime enrollmentDate = enrollment.GetEnrollmentDate();

                WriteLine($"Student: {enrolledStudent.Name}, Course: {enrolledCourse.CourseName}, Enrollment Date: {enrollmentDate}");

            }

            WriteLine("--------------------------------------------------------------------------------------");

            ConsoleUserInterface userInterface = new ConsoleUserInterface(appEngine);

            // Show the first screen of the user interface

            userInterface.showFirstScreen();

            Read();

        }

        static void Scenario1()

        {

            WriteLine("-----Scenario-1----------");

            // Create objects of the Student class

            Student student1 = new Student(1, "Arun", new DateTime(2000, 5, 10));

            Student student2 = new Student(2, "Ram", new DateTime(2001, 8, 17));

            Student student3 = new Student(3, "ramesh", new DateTime(2001, 5, 25));

            // Call the display method for each student

            Info info = new Info();

            info.Display(student1);

            info.Display(student2);

            info.Display(student3);

            WriteLine("----------------------------------------------------------------------");

        }

        static void Scenario2()

        {

            WriteLine("-----Scenario-2----------");

            // Create an array of Student class and store objects in it

            Student[] students = new Student[3];

            students[0] = new Student(1, "Ramya", new DateTime(2011, 7, 14));

            students[1] = new Student(2, "Teja", new DateTime(2001, 2, 7));

            students[2] = new Student(3, "Mahesh", new DateTime(2002, 9, 12));

            // Create an Info object

            Info info = new Info();

            // Iterate over the array and call the display method for each student

            foreach (Student student in students)

            {

                info.Display(student);

            }

        }

    }

}