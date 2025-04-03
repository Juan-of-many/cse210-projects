using System;
using System.Drawing;
using System.Formats.Asn1;

class SimpleGoal : Goal
{
    private string _answer;

    public SimpleGoal()
    : base()
    {}

    public override void DeterminePoints()
    {
        Console.WriteLine("This system is set in a 1000 point system.");
        Console.WriteLine("The greater a goal's impact, and the greater a goal's difficulty, the more points the goal should be worth. If you have chosen a different way to accredit value to your goals, you are given the freedom to do so.");
    
        Console.WriteLine();
        Console.Write("How many points do you think this goal is worth?");
        string userPoints = Console.ReadLine();
        _points = Int32.Parse(userPoints);
    }
    public override void ReportProgress()
    {
        Console.WriteLine("Have you completed your goal? [y/n]: ");
        _answer = Console.ReadLine();
        _answer = _answer.ToLower();

        if (_answer == "y" || _answer == "ye" || _answer == "yes")
        {
            //completed goal
            SetComplete();
        }
        else if (_answer == "n" || _answer == "no")
        {
            //exit without completion
        }
    }
}