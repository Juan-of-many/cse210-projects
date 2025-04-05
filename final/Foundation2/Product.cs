using System;
using System.Data.Common;
using System.Runtime.Intrinsics.X86;

public class Product
{
    private string _name;
    private string _id; //string for non-mathable
    private double _price;
    private int _quantity; 

    //constructor
    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    //action (math) (returns something)
    public double CalculateTotalPrice()
    {
        double totalCost = _price * _quantity;
        return totalCost;
    }

    //getters and setters
    public string GetName()
    {
        return _name;
    }
    public string GetId()
    {
        return _id;
    }
}