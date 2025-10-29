using System;
using System.Runtime.CompilerServices;

public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    public abstract string GetDistance(); //changing to strings
    public abstract string GetSpeed(); //changing to strings 
    public abstract string GetPace(); //changing to strings 
    public string GetSummary()
    {
        return $"{_date:dd MMM yyy} {GetType().Name} ({_length} min) - Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}"; //GetType().Name is returning the name of the class
    }

}