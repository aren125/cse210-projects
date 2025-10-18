using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName() // breaking up get info from design into 3 separate getters instead to help with GetStringRepresentation
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract string GetStringRepresentation();
    public abstract string GetStatus(); //clearer method name since I already have the bool _isComplete 

    
}