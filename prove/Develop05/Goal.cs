using System;
using System.Drawing;

//whole class is called abstract because it contains functions that need abstract?
public abstract class Goal
{
    private string _title;
    private string _description;
    protected int _points;
    protected bool _complete;

    public Goal() //yonder constructor is a setter
    {
        _complete = false;
    }
        
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public virtual bool GetComplete()
    {
        return _complete;
    }
    public void SetComplete()
    {
        _complete = true;
    }

    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();

        Console.Write("Please provide a short description of your goal: ");
        _description = Console.ReadLine();

        DeterminePoints(); //each child determines points in its own way.
    }
    public abstract void DeterminePoints();
    public virtual void ReportProgress()
    {

    }
}