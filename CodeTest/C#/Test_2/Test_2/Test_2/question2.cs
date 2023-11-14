
using System;

using System.Collections.Generic;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
}
class Program2
{
    static void Main()
    {
        List<Product> products = new List<Product>();
        for (int i = 1; i <= 10; i++)//using for loop accepting the 10 products with user inputs
        {
            Console.WriteLine($"Enter details for Product {i}:");

            Console.Write("Product ID (in num format): ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Product Name (in string format)  : ");
            string productName = Console.ReadLine();

            Console.Write("Price : ");
            double price = double.Parse(Console.ReadLine());

            Product prod = new Product
            {
                ProductId = productId,
                ProductName = productName,
                Price = price
            };
            products.Add(prod);
        }
        // Sort the products based on price
        products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
        // Display the sorted products
        Console.WriteLine("\n  Here is the Sorted Products by Price:");
        Console.WriteLine("\n    "  );
        foreach (Product product in products)
        {
            Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
        }

    }

}