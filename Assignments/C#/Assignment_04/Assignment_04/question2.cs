
using System;

class Student

{
      int RollNo;

      string Name;

      string Class;

      int Semester;

      string Branch;

      int[] Marks = new int[5];

    public Student(int rollNo, string name, string className, int sem, string branch)

    {

        RollNo = rollNo;

        Name = name;

        Class = className;

        Semester = sem;

        Branch = branch;

    }



    public void GetMarks(int[] marks)

    {

        if (marks.Length == 5)

        {

            for (int i = 0; i < 5; i++)

            {

                Marks[i] = marks[i];

            }

        }

    }


    public void DisplayResult()

    {

        int totalMarks = 0;

        foreach (int mark in Marks)

        {

            totalMarks += mark;

        }

        double averageMarks = totalMarks / 5.0;



        Console.WriteLine("Student Name: " + Name);

        Console.WriteLine("Roll Number: " + RollNo);

        Console.WriteLine("Class: " + Class);

        Console.WriteLine("Semester: " + Semester);

        Console.WriteLine("Branch: " + Branch);

        Console.WriteLine("Marks:");

        for (int i = 0; i < 5; i++)

        {

            Console.WriteLine("Subject " + (i + 1) + ": " + Marks[i]);

        }

        if (Marks[0] < 35 || Marks[1] < 35 || Marks[2] < 35 || Marks[3] < 35 || Marks[4] < 35 || averageMarks < 50)

        {

            Console.WriteLine("The Result is : Failed");

        }

        else
        {

            Console.WriteLine("The Result is : Passed");

        }

    }
    public static void Main(string[] args)

    {

        Console.Write("PLease enter the  Roll Number: ");

        int rollNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Student Name: ");

        string name = Console.ReadLine();

        Console.Write("Enter Class: ");

        string className = Console.ReadLine();

        Console.Write("Enter Semester: ");

        int semester = int.Parse(Console.ReadLine());

        Console.Write("Enter Branch: ");

        string branch = Console.ReadLine();

        int[] studentMarks = new int[5];

        for (int i = 0; i < 5; i++)

        {

            Console.Write($"Enter Marks for Subject {i + 1}: ");

            studentMarks[i] = int.Parse(Console.ReadLine());

        }

        Student stud = new Student(rollNo, name, className, semester, branch);

        stud.GetMarks(studentMarks);

        stud.DisplayResult();

    }

}