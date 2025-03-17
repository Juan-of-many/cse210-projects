using System;
using System.Drawing;

class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
    : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {   
        double radiusSquared = _radius * _radius;
        return radiusSquared * Math.PI;
    }
}