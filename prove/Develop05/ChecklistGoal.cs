using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

public class ChecklistGoal : Goal
{
    private int _completedCount;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        _completedCount = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;

    }

    public override void RecordEvent()
    {
        if (_completedCount < _targetCount)
        {
            _completedCount++; //add 1 to completed count when event is recorded
            Console.WriteLine($"Congratulations, you have earned {GetPoints()} points!");
            if (_completedCount == _targetCount)
            {
                Console.WriteLine($"Goal Completed! \nYou have completed this goal {_targetCount} times! You have earned {_bonusPoints} bonus points!");
            }

        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override string GetStatus()
    {
        if (_completedCount == _targetCount)
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
        return $"CheclistGOal:{GetName()},{GetDescription()},{GetPoints()},{_completedCount},{_targetCount},{_bonusPoints}";
    }

}
