using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal); // add goals to _goals list
    }

    public void ListGoals()
    {
        for (int i = 0; i <_goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetStatus()} {_goals[i].GetName()} - {_goals[i].GetDescription()}");
        }

    }

    public void RecordEvent(int index)
    {
        _goals[index].RecordEvent(); // makes sure goal is recorded
        _score += _goals[index].GetPoints(); // add points for completed goal

    }

    public void SaveGoals(string fileName)
    {

    }

    public void LoadGoals(string fileName)
    {

    }
    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }
}