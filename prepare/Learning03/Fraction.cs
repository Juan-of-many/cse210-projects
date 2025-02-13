using System;

public class Fraction
{
   private int _top;
   private int _bottom;

    //constructor
    //this one is our preset values only.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //constructor which allows user to provide something refered to as "wholeNumber"
    //it is called wholeNumber because the numerator can change, while the denominator is always one when using this preset constructor.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //constructor allows user to provide top and bottom, numerator and denominator.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double coolDecimal = (double)_top/(double)_bottom; //I don't know why the math is throwing a hissy fit and requiring (double) in front of the integer values. Without them, it returns a 0. With them it returns 0.75.
        return coolDecimal;
    }
}
