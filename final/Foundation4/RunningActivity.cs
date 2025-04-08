using System;
using System.Security.Cryptography;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double time, double distance)
    :base
    (
        date,
        time,
        "Running"
    )
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        //because running starts with distance as an input, this is essentially a getter
        return _distance; //km
    } 

    public override double CalculateSpeed()
    {
        double hourTime = ConvertTimeToHours();//from minutes to hours

        double speedAverage = _distance / hourTime; //km per hour
        return speedAverage;
    } 

    public override double CalculatePace()
    {
        //minutes per kilometer
        double pace = _time / _distance;
        return pace;
    } 
}