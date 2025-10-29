using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Counting Street", "Rexburg", "ID", "USA");
        Address a2 = new Address("456 Queen Street", "London", "England", "UK");

        Customer c1 = new Customer("Audrey Rentz", a1);
        Customer c2 = new Customer("Bridget Rentz", a2);

        //I know these are produce products and this is online ordering, 
        // but its easier to think of produce items than anythng else for testing the program

        List<Product> products1 = new List<Product>
        {
        new Product("Strawberries", "SB03", 5.00, 2),
        new Product("Bag of Apples", "A200", 4.00, 1),
        new Product("Banana", "b100", 0.10, 7)
        };

        List<Product> products2 = new List<Product>
        {
        new Product("Chips", "cp05", 3.50, 2),
        new Product("Chocolate Chip Cookies", "cc20", 6.00, 1),
        new Product("Ritz Crackers", "rc77", 2.00, 2)
        };

        Order o1 = new Order(c1, products1);
        Order o2 = new Order(c2, products2);
        

        Console.WriteLine("Order 1:");
        o1.GetPackingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total: ${o1.GetTotalPrice()}");
        Console.WriteLine();
        o1.GetShippingLabel();

        Console.WriteLine();
        Console.WriteLine("-----------------------------------"); //spacing

        Console.WriteLine("Order 2:");
        o2.GetPackingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total: ${o2.GetTotalPrice()}");
        Console.WriteLine();
        o2.GetShippingLabel();
    }
} 