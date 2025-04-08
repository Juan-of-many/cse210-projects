using System;
using System.Dynamic;

public abstract class Activity
{
    private string _type;
    private string _date;
    protected double _time; //length of activity in minutes(mathable and accepting partial minute mark) 
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    //I have opted to use the metric system

    public Activity(string date, double time, string type)
    {
        _date = date;
        _time = time;
        _type = type;
    }

    public double ConvertTimeToHours()
    {
        double hourTime = _time / 60;
        return hourTime;
    }

    public string GetSummary()
    {
        double distance = CalculateDistance();
        double speed = CalculateSpeed();
        double pace = CalculatePace();

        //Round the values to the nearest 1, 1, and 2 decimal points respectively.
        //Rounded numbers are kept out of the calculations, only done here after all calculations are finished.
        double roundedDistance = Math.Round(distance, 1, MidpointRounding.AwayFromZero);
        double roundedSpeed = Math.Round(speed, 1, MidpointRounding.AwayFromZero);
        double roundedPace = Math.Round(pace, 2, MidpointRounding.AwayFromZero);

        //format the data as directed.
        string summary = $"{_date} {_type} ({_time} min): Distance: {roundedDistance} km, Speed: {roundedSpeed} kph, Pace: {roundedPace} min per km";
        return summary;
    }
}