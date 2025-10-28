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

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetSpace();
    public abstract string GetSummary(); //for now - might not override this method

}