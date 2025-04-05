using System;
using System.Net.Sockets;

public class Customer
{

    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool CheckNationality()
    {
        string nationalityAnswer = _address.DetermineNationality();

        bool response;
        if (nationalityAnswer == "domestic")
        {
            response = true; //"This person lives in the United States of America."
        }
        else
        {
            response = false; //"This person does not live in the United States of America."
        }
        
        return response;
    }

    //getters and setters
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
}