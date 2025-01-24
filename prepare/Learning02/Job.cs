using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear; //not yet assigned a value, but told it is meant to be an int... I do not know if this fully works.
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}

//behavior 
//Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".