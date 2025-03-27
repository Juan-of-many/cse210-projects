using System;
using System.Drawing;

class Simplegoal : Goal
{
    private double _side;
    public Square(string color, double side)
    : base ()
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}