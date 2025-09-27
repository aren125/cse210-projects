using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>(); //Making a list out of objects in the Entry class. 

    public void AddEntry(string date, string prompt, string response, int rating)
    {
        Entry newEntry = new Entry(date, prompt, response, rating); //using the entry constructor from Entry.cs

        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine("\n Journal Entries \n");

        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry(); //calling the method from Entry.cs
        }
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }
}
