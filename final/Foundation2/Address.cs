using System;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _provinceOrState;
    private string _country;

    //setter in the form of constructor
    public Address(string street, string city, string provinceOrState, string country)
    {
        _streetAddress = street;
        _city = city;
        _provinceOrState = provinceOrState;
        _country = country;
    }

    public string DetermineNationality()
    {
        string nationality;

        string workableCountry = _country.ToLower(); //creating new variable to be changed to lowercase. Original variable unaltered
        if (workableCountry == "usa" || workableCountry == "us" || workableCountry == "united states" || workableCountry == "united states of america" || workableCountry == "united states america") 
        {
            //USA
            nationality = "domestic";
        }
        else 
        {
            //not USA
            nationality = "foreign";
        }
        
        return nationality;
    }

    public string FormatAddress()
    {
        //take details of address and format them for a shipping label.
        string formattedAddress = 
        $"{_streetAddress}{Environment.NewLine}{_city} {_provinceOrState}{Environment.NewLine}{_country}";

        return formattedAddress;
    }
}