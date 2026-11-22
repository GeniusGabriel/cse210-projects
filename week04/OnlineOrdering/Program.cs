using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address = new Address("123 Main Street", "Goaso", "Ahafo", "Ghana");
        Address address1 = new Address("WhiteHouse", "New York", "State1", "USA");

        // Create customers
        Customer customer = new Customer("Gabriel", address);
        Customer customer1 = new Customer("Paul", address1);

        // Create orders
        Order order = new Order(customer);
        Order order1 = new Order(customer1);

        // Create products
        Product product = new Product("laptop", "798912", 20.20m, 1);
        Product product1 = new Product("webcam", "23488", 789.8m, 4);
        Product product2 = new Product("phone", "88889", 4.4m, 2);

        // Add products to Gabriel's order
        order.AddProduct(product);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Add products to Paul's order
        order1.AddProduct(product);
        order1.AddProduct(product2);

        // Display Gabriel's order
        Console.WriteLine("===== GABRIEL'S ORDER =====");
        Console.WriteLine($"Packing Label:\n{order.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order.GetTotalCost():C}");

        // Display Paul's order
        Console.WriteLine("\n===== PAUL'S ORDER =====");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order1.GetTotalCost():C}");
    }
}