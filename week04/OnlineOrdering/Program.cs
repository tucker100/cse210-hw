using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Sarah Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-1001", 19.99, 2));
        order1.AddProduct(new Product("USB-C Cable", "UC-2040", 8.50, 3));
        order1.AddProduct(new Product("Laptop Stand", "LS-3300", 34.95, 1));

        Address address2 = new Address("15 Adeola Odeku Street", "Victoria Island", "Lagos", "Nigeria");
        Customer customer2 = new Customer("Chinedu Okafor", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Solar Power Bank", "SP-4500", 45.00, 1));
        order2.AddProduct(new Product("Bluetooth Headphones", "BH-7720", 59.99, 2));

        List<Order> orders = new List<Order> { order1, order2 };

        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"===== Order {orderNumber} =====");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}");
            Console.WriteLine();
            orderNumber++;
        }
    }
}