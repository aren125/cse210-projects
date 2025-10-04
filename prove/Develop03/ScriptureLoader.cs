using System;
using System.Collections.Generic;

//Exceeding Requirements

public class ScriptureLoader //load scriptures from file
{
    private List<Scripture> _scriptures = new List<Scripture>();

    public ScriptureLoader(string fileName)
    {
        LoadScriptures(fileName);
    }

    public List<Scripture> GetScriptures() //A _scriptures "getter" since the _scriptures list is private
    {
        return _scriptures;
    }

    public Scripture GetRandomScripture() //Get random scripture from scriptures list
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }

    private void LoadScriptures(string fileName) //load scriptures from file and assign attributes/variables
    {
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if ((parts.Length) == 4) //book, chapter, verse, scripture
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                string text = parts[3];

                Reference reference = new Reference(book, chapter, verse);
                Scripture scripture = new Scripture(reference, text);
                _scriptures.Add(scripture);
            }

            else if (parts.Length == 5) //book, chapter, startVerse, endVerse, scripture
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int startVerse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                string text = parts[4];

                Reference reference = new Reference(book, chapter, startVerse, endVerse);
                Scripture scripture = new Scripture(reference, text);
                _scriptures.Add(scripture);

            }
        }


    }
}