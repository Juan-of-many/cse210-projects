using System;
using System.Reflection;
using Microsoft.VisualBasic;

public class Event
{
    //variables
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;
    private string _informationByType;

    //constructor
    public Event(string title, string description, string date, string time, Address address, string type, string informationByType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address; //class
        _type = type;
        _informationByType = informationByType;
    }

    public string GenerateStandard()
    {
        //list title, description, date, time, address
        return $"Title: {_title}{Environment.NewLine}Description: {_description}{Environment.NewLine}Date: {_date} - Time: {_time}{Environment.NewLine}Location:{Environment.NewLine}{_address.FormatAddress()}";
    }

    public string GenerateFull()
    {
        //list title, description, date, time, address
        //type of event and type-specific information.  For lectures, this includes the speaker name and capacity. 
        // For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
        string standardInfo = GenerateStandard();

        string fullInfo = standardInfo + Environment.NewLine + $"Event type: {_type}{Environment.NewLine}Heads up! {_informationByType}";
        return fullInfo;
    }

    public string GenerateShort()
    {
        //Lists the type of event, title, and the date.
        return $"Event type: {_type}{Environment.NewLine}Title: {_title}{Environment.NewLine}Date: {_date}";
    }
}