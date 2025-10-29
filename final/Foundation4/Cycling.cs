using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override string GetDistance()
    {
        double distance = Math.Round((_speed / 60) * GetLength(), 1);
        return $"{distance} miles";
    }

    public override string GetSpeed()
    {
        return $"{_speed} mph";
    }

    public override string GetPace()
    {
        double pace = Math.Round(60 / _speed, 2);
        return $"{pace} min per mile";
    }

}