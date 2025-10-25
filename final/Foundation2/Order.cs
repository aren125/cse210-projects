using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        if (_customer.LivesInUSA())
        {
            total += 5; //shipping cost in USA
        }
        else
        {
            total += 35; //shipping cost outside USA
        }
        return total;
    }

    public void GetPackingLabel() //changed to void from string to use Console.WriteLine instead of return
    {
        Console.WriteLine("--- Packing Label ---");
        foreach(Product p in _products)
        {
            Console.WriteLine($"{p.GetProductName()}: {p.GetProductId()} - QTY: {p.GetQuantity()}");
        }
    }
    
    public void GetShippingLabel()
    {
        Console.WriteLine("--- Shipping Label ---");
        Console.WriteLine($"{_customer.GetCustomerName()}");
        Console.WriteLine($"{_customer.GetAddress()}");
    }
}