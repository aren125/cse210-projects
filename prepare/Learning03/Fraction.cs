using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
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
        int top = _top;
        int bottom = _bottom; //while comparing to the sample, lines 45 - 46 are unecessary if I call _top and _bottom directly in the string
        string fractionString = $"{top}/{bottom}";
        return fractionString;
    }

    public double GetDecimalValue() //I keep wanting to use float instead of double - USE DOUBLE
    // also I use these assignment from prepares as notes, which is why I comment things like this. Hopefully this doesn't bother you :)
    {
        return (double)_top / (double)_bottom; //change to double for the decimal value, otherwise it will return int
    }
}