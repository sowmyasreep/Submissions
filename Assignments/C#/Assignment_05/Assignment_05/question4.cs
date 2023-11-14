using System;
namespace Assignment_05
{
    class Customer
    {
        int CustomerId;
        string Name;
        int Age;
        long Phone;
        string City;
        public Customer()
        {
            CustomerId = 0;
            Name = "  ";
            Age = 0;
            Phone = 0;
            City = "   ";
        }
        public Customer(int customerId, string name, int age, long phone, string city)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }
        public static void DisplayCustomer(Customer cust)
        {
            Console.WriteLine("Customer ID: " + cust.CustomerId);
            Console.WriteLine("Name: " + cust.Name);
            Console.WriteLine("Age: " + cust.Age);
            Console.WriteLine("Phone: " + cust.Phone);
            Console.WriteLine("City: " + cust.City);
        }
        ~Customer()
        {
            Console.WriteLine(" Destructor called....    ");
        }
    }
    class question4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer ID:");
            int customerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phone:");
            long phone =Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();
            Customer cust = new Customer(customerId, name, age, phone, city);
            Customer.DisplayCustomer(cust);
            // This will call the destructor when the program exits
        }
    }
}
