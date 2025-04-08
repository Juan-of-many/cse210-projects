using System;

public class SwimmingActivity : Activity
{
    private double _lapCount;

    public SwimmingActivity(string date, double time, double lapCount)
    :base
    (
        date,
        time,
        "Swimming"
    )
    {
        _lapCount = lapCount;
    }

    public override double CalculateDistance()
    {
        //dist = laps * length of pool
        //length of pool lap = 50 meters
        //50 meters / 1000 = 0.05 kilometers
        double distance = _lapCount * 0.05;
        return distance; //km
    } 

    public override double CalculateSpeed()
    {
        //need to convert variables.
        double hourTime = ConvertTimeToHours();//from minutes to hours
        double distance = CalculateDistance();//from laps to km

        double speedAverage = distance / hourTime; //km per hour
        return speedAverage;
    } 

    public override double CalculatePace()
    {
        //minutes per kilometer
        double distance = CalculateDistance();
        double pace = _time / distance;
        return pace; //minutes per kilometer
    } 
}

