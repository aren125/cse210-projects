using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; //default, all words are visible
    }

    public string DisplayText()
    {
        if (_isHidden)
        {
            string hiddenWord = "";
            for (int i = 0; i < _text.Length; i++)
            {
                hiddenWord += "_"; // I might come back and add spaces between the _
            }
            return hiddenWord;
        }
        else
        {
            return _text;
        }
    }

    public void HideWord() //change the bool to true, for example, _words[index].HideWord()
    {
        _isHidden = true;
    }

    public bool IsHidden() //needed because the _isHidden attribute is private. Check if word is hidden
    {
        return _isHidden;
    }

}

