using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

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
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            outputFile.WriteLine($"Score:{_score}"); //save the score
        }
        Console.WriteLine("Your goals have been saved.");

    }

    public void LoadGoals(string fileName)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            if (line.StartsWith("Score:"))
            {
                _score = int.Parse(line.Split(':')[1]);
            }
            else
            {
                Goal g = CreateGoalFromString(line);
                _goals.Add(g);
            }
            Console.WriteLine("Your goals have been loaded.");
        }

    }
    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public static Goal CreateGoalFromString(string line)
    {
        string[] parts = line.Split(':');
        string type = parts[0];
        string[] details = parts[1].Split(',');
        if (type == "SimpleGoal")
        {
            SimpleGoal sg = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
            if (bool.Parse(details[3]))
            {
                sg.RecordEvent(); // if the bool is true- if the goal has been completed, check the box
            }
            return sg;
        }
        else if (type == "EternalGoal")
        {
            return new EternalGoal(details[0], details[1], int.Parse(details[2]));
        }
        else if (type == "ChecklistGoal")
        {
            ChecklistGoal cg = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[4]), int.Parse(details[5]));
            for (int i = 0; i < int.Parse(details[3]); i++)
            {
                cg.RecordEvent();
            }
            return cg;
        }
        else
        {
            throw new Exception("Unknown goal type");
        }
        
    }
}