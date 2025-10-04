using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>(); //each word will be an object
    public Scripture(Reference reference, string text) // Constructor for Scripture
    {
        _reference = reference;
        SplitTextIntoWords(text); //split the string into words
    }

    private void SplitTextIntoWords(string text) //Split the string so that each word is a string
    {
        string[] splitWords = text.Split(" "); //split by spaces
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word)); //add each word to _words list
        }
    }
    public void Display() //displays both reference and scripture text
    {
        Console.WriteLine(_reference.GetReferenceText());
        foreach (Word word in _words)
        {
            Console.Write($"{word.DisplayText()} ");
        }
    }

    public void HideRandomWords(int count) //randomly hide words
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>(); //visible words-not hidden

        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                visibleWords.Add(word);
            }
        }

        if (count > visibleWords.Count)
        {
            count = visibleWords.Count; //Change count to be the same number as the left over words
        }

        for (int i = 0; i < count; i++) //count?
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].HideWord(); //HideWord function will be called from the word class
            visibleWords.RemoveAt(index);
        }
    }
    public bool AllWordsHidden() //boolean to quit program if true
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false) //loop through each word, if any word is not hidden, return false
            {
                return false;
            }
        }
        return true; // return true if all words are hidden to quit program
    }
}