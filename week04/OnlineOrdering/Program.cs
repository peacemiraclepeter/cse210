using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("12 Main Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Laptop", "P100", 800, 1);
        Product product2 = new Product("Mouse", "P101", 25, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address("45 King Road", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Sarah Johnson", address2);

        Product product3 = new Product("Phone", "P200", 600, 1);
        Product product4 = new Product("Headphones", "P201", 50, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine("PACKING LABEL");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("SHIPPING LABEL");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");

            Console.WriteLine();
        }
    }
}