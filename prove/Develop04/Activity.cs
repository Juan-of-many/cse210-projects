using System;
using System.ComponentModel.DataAnnotations;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private int _timeSpent;

    public Activity(string name, string description)
    {
        //set defaults. This constructor does not feel like it is doing anything useful.
        _activityName = name;
        _description = description;
        _duration = 50;
    }

    public void DisplayStart() //this starts off all activities and sets the duration
    {
        Console.Clear();
        
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();

        Console.WriteLine("How long, in seconds, would you like your session to last? ");
        string rawDuration = Console.ReadLine();
        _duration = Int32.Parse(rawDuration);
    }

    public void SetTimeSpent()
    {
        _timeSpent = 0;
    }

    public void TrackTimeSpent(int time)
    {   
        //add the time that has passed to _timeSpent
        _timeSpent += time;
    }
    public int GetTimeSpent()
    {
        return _timeSpent;
    }

    public void AnimationPause(int version)
    {
        //this is the pause/loading animation

    }

    public void DisplayEnd()
    {

    }

    //redundant? instead just call AssembleInstructions?
    /*public void RunActivity()
    {

    }*/
}