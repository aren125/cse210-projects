using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    { }

    public override string GetDisplayString()
    {
        return $"{GetStatus()} {GetName()} - {GetDescription()}";
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have earned {GetPoints()} points!"); //math/score done in goal manager
    }

    public override string GetStatus()
    {
        return "[ ]";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()}, {GetPoints()}";
    }
}