using System;

public class BicycleActivity : Activity
{
    private double _speedAverage;

    public BicycleActivity(string date, double time, double speedAverage)
    :base
    (
        date,
        time,
        "Cycling"
    )
    {
        _speedAverage = speedAverage;
    }

    public override double CalculateDistance()
    {
        //dist = speed * time (need to be based in the same measurement of time)
        double hourTime = ConvertTimeToHours(); //speed is already based in hours, so change time to hours.

        double distance = _speedAverage * hourTime;
        return distance; //km
    } 

    public override double CalculateSpeed()
    {
        //because bicycling starts with speedaverage as an input, this is essentially a getter
        return _speedAverage; //kilometer per hour
    } 

    public override double CalculatePace()
    {
        //minutes per kilometer
        double distance = CalculateDistance();
        double pace = _time / distance;
        return pace; //minutes per kilometer
    } 
}