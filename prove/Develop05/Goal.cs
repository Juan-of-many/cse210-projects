using System;
using System.Drawing;

//whole class is called abstract because it contains functions that need abstract?
public abstract class Goal
{
    private string _title;
    private string _description;
    private int _points;
    protected bool _complete;

    public Goal(string title, string description, int points) //yonder constructor is a setter
    {
        _title = title;
        _description = description;
        _points = points; 
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

    public abstract void RecordEvent();
    public virtual bool IsComplete()
    {
        return _complete;
    }
}