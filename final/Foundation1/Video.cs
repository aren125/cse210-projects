using System;
using System.Collections.Generic;
public class Video
{
    private string _title;
    private string _author;
    private float _lengthSeconds;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return _comments.Count();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds / 60} minutes");
        Console.WriteLine($"Comments: {GetCommentCount()}");

        foreach (Comment c in _comments)
        {
            Console.WriteLine($"-{c.GetComment()}");
        }
    }


}