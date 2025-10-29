using System;
using System.Data;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override string GetDistance()
    {
        double distance = Math.Round(_laps * 50 / 1000 * 0.62, 1);
        return $"{distance} miles";
    }

    public override string GetSpeed()
    {
        double speed = Math.Round(((_laps * 50 / 1000 * 0.62) / GetLength()) * 60, 1);
        return $"{speed} mph";
    }

    public override string GetPace()
    {
        double pace = Math.Round(GetLength() / (_laps * 50 / 1000 * 0.62), 2);
        return $"{pace} min per mile";
    }
    
}