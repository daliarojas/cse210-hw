using System;
using System.Collections.Generic;

namespace ordering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating addresses
            Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            Address address2 = new Address("456 Elm St", "Othertown", "NY", "USA");

            // Creating customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            // Creating products
            Product product1 = new Product("Laptop", 101, 1200, 1);
            Product product2 = new Product("Headphones", 102, 50, 2);
            Product product3 = new Product("Mouse", 103, 20, 3);

            // Creating orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Displaying results
            Console.WriteLine("Order 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

            Console.WriteLine("\nOrder 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
        }
    }
}