using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete; // constructor for loading
    }

    public override string GetDisplayString()
    {
        return $"{GetStatus()} {GetName()} - {GetDescription()}";
    }

    public override void RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations, you have earned {GetPoints()} points!");
        }
        else
        {
            Console.WriteLine("This goal is already completed."); // in case the goal is already completed
        }
    }

    public override string GetStatus()
    {
        if (_isComplete == true)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }

    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
    
}