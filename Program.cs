using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}
    class Program
    {
        static void InsertionSort(List<Product> products)
    {
        int n = products.Count;
        for (int i = 1; i < n; i++)
        {
            Product key = products[i];
            int j = i - 1;

            
            while (j >= 0 && products[j].Price > key.Price)
            {
                products[j + 1] = products[j];
                j--;
            }
            products[j + 1] = key;
        }
    }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1500 },
            new Product { Name = "Mouse", Price = 25 },
            new Product { Name = "Keyboard", Price = 45 },
            new Product { Name = "Monitor", Price = 300 },
            new Product { Name = "Headphones", Price = 80 }
        };

        Console.WriteLine("Before Sort :");
        foreach (var product in products)
        {
            Console.WriteLine(product.Name + ": " + product.Price );
        }

        InsertionSort(products);

        Console.WriteLine("\nAfter Sort:");
        foreach (var product in products)
        {
            Console.WriteLine(product.Name + ": " + product.Price );
        }
        }
    }
}
