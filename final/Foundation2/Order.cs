using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

public class Order
{
    private List<Product> _products;
    private Customer _customer; 
    private double _costBeforeShipping;
    private double _shippingCost;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
        //for as long as each order is only accredited to one customer, this works. (If different users' orders are combined and have different shipping destinations, this breaks the shipping cost calculations.)
        DetermineShippingCost();
    }
    
    public void DetermineShippingCost()
    {
        bool inUSA = _customer.CheckNationality();

        if (inUSA == true)
        {
            //$5 shipping for domestic, in US
            _shippingCost = 5;
        }
        else if (inUSA == false)
        {
            //$35 shipping for foreign, outside US
            _shippingCost = 35;
        }
    }

    public double CalculateOrderPrice()
    {
        //For each product in list of products, add price to running total
        double runningProductTotal = 0;

        foreach (Product product in _products)
        {
            double price = product.CalculateTotalPrice();
            runningProductTotal = runningProductTotal + price;
        }
        
        //set _costBeforeShipping to running total without shipping cost to let customer know the total price of goods and the separate shipping cost.
        _costBeforeShipping = runningProductTotal;

        //at the very end, because this is a shipping company, add the shipping cost.
        double total = runningProductTotal + _shippingCost;
        return total;
    }    

    public string CreatePackingLabel()
    {
        //get name
        string customerName = _customer.GetName();
        //create top of packing label
        string packingLabel = customerName + Environment.NewLine + "~~~~~~~~~~~~~";

        //packing label = the itemized contents by name and id
        foreach (Product product in _products)
        {
            string name = product.GetName();
            string id = product.GetId();
            
            //Format for one line: 12345  -  donut
            packingLabel = packingLabel + Environment.NewLine + id + "  -  " + name;
        }

        return packingLabel;
    }

    public string CreateShippingLabel()
    {
        //shipping label = shipping address including name
        string customerName = _customer.GetName();
        
        Address address = _customer.GetAddress();
        string assembledAddress = address.FormatAddress();

        string shippingLabel = customerName + Environment.NewLine + assembledAddress;
        return shippingLabel;
    }

    public double GetShippingCost()
    {
        return _shippingCost;
    }
    public double GetCostBeforeShipping()
    {
        return _costBeforeShipping;
    }
}