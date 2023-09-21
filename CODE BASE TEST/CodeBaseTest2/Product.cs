using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<Product> productList = new List<Product>();

      
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Enter details for Product {i}:");
            Console.Write("Product ID: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Product Name: ");
            string productName = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            
            Product product = new Product(productId, productName, price);
            productList.Add(product);
        }

        
        productList.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));

       
        Console.WriteLine("\nSorted Products by Price:");
        foreach (Product product in productList)
        {
            Console.WriteLine($"{product.ProductID}\t{product.ProductName}\t{product.Price:C}");
        }
    }
}

class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }

    public Product(int productId, string productName, double price)
    {
        ProductID = productId;
        ProductName = productName;
        Price = price;
    }
}