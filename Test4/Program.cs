using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int listCount = 0;

        while (true)
        {
            listCount = DisplayCount(listCount);
        }
    }

    static int DisplayCount(int previousCount)
    {
        var myList = new List<Product>(); // Specify the type parameter as Product

        // Populate list with 1000 integers  
        for (int i = 0; i < 1000; i++)
        {
            myList.Add(new Product(Guid.NewGuid().ToString(), i));
        }

        // Display the count of the list without keeping references to objects
        Console.WriteLine(myList.Count);

        // Return the count to be used in the loop condition
        return myList.Count;
    }
}

class Product
{
    public Product(string sku, decimal price)
    {
        SKU = sku;
        Price = price;
    }

    public string SKU { get; set; }
    public decimal Price { get; set; }
}