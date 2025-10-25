using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProductName() //renamed GetProductName for clarity (previously GetName)
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public int GetQuantity() // I'm going to add the quantity of products to the packing label (as someone who has worked in shipping - its super important for a packing label lol)
    {
        return _quantity;
    }
}