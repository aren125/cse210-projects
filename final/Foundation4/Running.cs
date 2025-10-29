using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override string GetDistance() //changed to string to add miles
    {
        return $"{_distance} miles";
    }

    public override string GetSpeed() //changed to string to add mph
    {
        double speed = Math.Round((_distance / GetLength()) * 60, 1);
        return $"{speed} mph";
    }

    public override string GetPace() //changed to string to add min per mile
    {
        double pace = Math.Round(GetLength() / _distance, 2);
        return $"{pace} min per mile";
    }
}