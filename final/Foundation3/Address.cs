using System;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    //Americans often omit country for anything within USA. 
    //If someone were having their wedding in the country Georgia, however, that specification is helpful.
    private string _country;

    //constructor
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string FormatAddress()
    {
        //format address
        string formattedAddress = 
        $"  {_streetAddress}{Environment.NewLine}  {_city} {_state}{Environment.NewLine}  {_country}";

        return formattedAddress;
    }
}