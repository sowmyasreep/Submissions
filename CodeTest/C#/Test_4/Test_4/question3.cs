

using System;

using System.Collections.Generic;

using System.Linq;

 

class Employee

{

    public int EmployeeID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Title { get; set; }

    public string DOB { get; set; } // Changed to string

    public string DOJ { get; set; } // Changed to string

    public string City { get; set; }

}



class MyDataprogram

{

    static void Main()

    {

        List<Employee> empList = new List<Employee>

 {

 new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = "16/11/1984", DOJ = "8/6/2011", City = "Mumbai" },

 new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = "20/08/1984", DOJ = "7/7/2012", City = "Mumbai" },

 new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = "14/11/1987", DOJ = "12/4/2015", City = "Pune" },

 new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = "3/6/1990", DOJ = "2/2/2016", City = "Pune" },

 new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = "8/3/1991", DOJ = "2/2/2016", City = "Mumbai" },

 new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = "7/11/1989", DOJ = "8/8/2014", City = "Chennai" },

 new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = "2/12/1989", DOJ = "1/6/2015", City = "Mumbai" },

 new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = "11/11/1993", DOJ = "6/11/2014", City = "Chennai" },

 new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = "12/8/1992", DOJ = "3/12/2014", City = "Chennai" },

 new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = "12/4/1991", DOJ = "2/1/2016", City = "Pune" }

 };



        // a. Display detail of all the employee

        Console.WriteLine("Employee Details:");

        foreach (var employee in empList)

        {

            Console.WriteLine($"{employee.EmployeeID} - {employee.FirstName} {employee.LastName}, {employee.Title}, {employee.City}, DOB: {employee.DOB}, DOJ: {employee.DOJ}");

        }



        // b. Display details of all the employee whose location is not Mumbai

        var notInMumbai = empList.Where(employee => employee.City != "Mumbai").ToList();

        Console.WriteLine("\nEmployees not in Mumbai:");

        foreach (var employee in notInMumbai)

        {

            Console.WriteLine($"{employee.EmployeeID} - {employee.FirstName} {employee.LastName}, {employee.Title}, {employee.City}, DOB: {employee.DOB}, DOJ: {employee.DOJ}");

        }



        // c. Display details of all the employee whose title is AsstManager

        var asstManagers = empList.Where(employee => employee.Title == "AsstManager").ToList();

        Console.WriteLine("\nAsstManagers:");

        foreach (var employee in asstManagers)

        {

            Console.WriteLine($"{employee.EmployeeID} - {employee.FirstName} {employee.LastName}, {employee.Title}, {employee.City}, DOB: {employee.DOB}, DOJ: {employee.DOJ}");

        }



        // d. Display details of all the employee whose Last Name starts with S

        var startsWithS = empList.Where(employee => employee.LastName.StartsWith("S")).ToList();

        Console.WriteLine("\nEmployees with Last Name starting with 'S':");

        foreach (var employee in startsWithS)

        {

            Console.WriteLine($"{employee.EmployeeID} - {employee.FirstName} {employee.LastName}, {employee.Title}, {employee.City}, DOB: {employee.DOB}, DOJ: {employee.DOJ}");

        }

    }

}
 