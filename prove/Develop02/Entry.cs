using System;
using System.Runtime.CompilerServices;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public int _rating; //additional requirements - save other information in the journal entry

    public Entry(string date, string prompt, string response, int rating)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _rating = rating;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine($"Day rating: {_rating}/10");
        Console.WriteLine(); //for spacing
    }

    public string GetSaveFormat() //To save as a single line in file
    {
        return $"{_date}|{_prompt}|{_response}|{_rating}";
    }

}