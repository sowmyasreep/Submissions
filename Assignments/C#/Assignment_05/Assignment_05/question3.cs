using System;

namespace Assignment_05
{
    class question3
    {
        int sales_Num;

        int product_Num;

        decimal price;

        DateTime date_of_sale;

        int Quantity;

        decimal Total_amount;

        public question3(int salesNo, int productNo, decimal pricee, int qty, DateTime dateOfSale)

        {

            sales_Num = salesNo;

            product_Num = productNo;

            price = pricee;

            Quantity = qty;

            date_of_sale = dateOfSale;

            Sales();

        }
        public void Sales()

        {
            Total_amount = price * Quantity;

        }

        public void Show()

        {

            Console.WriteLine("Sales No: " + sales_Num);

            Console.WriteLine("Product No: " + product_Num);

            Console.WriteLine("Price: " + price);

            Console.WriteLine("Quantity: " + Quantity);

            Console.WriteLine("Date of Sale: " + date_of_sale);

            Console.WriteLine("Total Amount: " + Total_amount);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter Sales No:");

            int salesNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product No:");

            int productNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price:");

            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity:");

            int qty = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of Sale (year-Month-date):");

            DateTime dateOfSale = DateTime.Parse(Console.ReadLine());

            question3 sale = new question3(salesNo, productNo, price, qty, dateOfSale);

            sale.Show();

            Console.Read();
        }

    }

}

