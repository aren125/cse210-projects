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
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}"); // differenct display for check list ex: 0/3
    
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
                if (g != null)
                {
                    _goals.Add(g);
                }
            }
        }
        Console.WriteLine("Your goals have been loaded.");

    }
    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public static Goal CreateGoalFromString(string line)
    {
        string[] parts = line.Split(':');
        if(parts.Length < 2)
        {
            return null; // will edit this out in LoadGoals 
        }
        string type = parts[0];
        string[] details = parts[1].Split(',');

         if (type == "SimpleGoal")
        {
            return new SimpleGoal(details[0], details[1], int.Parse(details[2]), bool.Parse(details[3]));
        }
        else if (type == "EternalGoal")
        {
            return new EternalGoal(details[0], details[1], int.Parse(details[2]));
        }
        else if (type == "ChecklistGoal")
        {
            return new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4]), int.Parse(details[5]));
        }
        else
        {
            return null; // again, remove in LoadGoals
        }

    }

    public int GetGoalCount()
    {
        return _goals.Count; //for the if statement in option 5 of Program.cs
    }
    
    public void DeleteGoal(int index) //for exceeding requirements
    {
        if (index >= 0 && index < _goals.Count)
        {
            _goals.RemoveAt(index);
        }
    }
}