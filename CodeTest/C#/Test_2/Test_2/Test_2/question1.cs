
using System;
abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }
        public abstract bool IsPassed(double grade);// Passing an Abstract method IsPassed
}
    // Subclass Undergraduate
    class Undergraduate : Student
    {
        public Undergraduate(string name, int studentId, double grade)
        {
            Name = name;

            StudentId = studentId;

            Grade = grade;
        }
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }
    // creating a subclass Graduate
    class Graduate : Student
    {
        public Graduate(string name, int studentId, double grade)
        {
            Name = name;

            StudentId = studentId;

            Grade = grade;
        }
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }
    class Program1
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter student name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Please enter student ID: ");

            int studentId = int.Parse(Console.ReadLine());

            Console.WriteLine(" Please enter student grade: ");

            double grade = double.Parse(Console.ReadLine());

            // Creating an  Undergraduate object

            Undergraduate undergrad = new Undergraduate(name, studentId, grade);

            bool undergradPassed = undergrad.IsPassed(undergrad.Grade);

            Console.WriteLine($"Undergraduate student {undergrad.Name} having an ID {undergrad.StudentId} is : {(undergradPassed ? "Passed" : "Failed")}.");

            // Creating an Graduate object

            Graduate grad = new Graduate(name, studentId, grade);

            bool gradPassed = grad.IsPassed(grad.Grade);

            Console.WriteLine($"Graduate student {grad.Name}  having an  ID {grad.StudentId} is : {(gradPassed ? "Passed" : "Failed")}.");

        }

    }