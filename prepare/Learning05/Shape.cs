using System;
using System.Drawing;

//whole class is called abstract because it contains functions that need abstract?
public abstract class Shape
{
    private string _color;

    public Shape(string color) //yonder constructor is a setter
    {
        _color = color;   
    }
        
    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();
    //alternate instead of abstract
    /*
        public virtual double GetArea()
        {
            return 0;
        }
    */
}