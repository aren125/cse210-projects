using System;

public class Comment
{
    private string _commenterName;
    private string _comment;

    public Comment(string commenterName, string comment)
    {
        _commenterName = commenterName;
        _comment = comment;
    }

    public string GetComment()
    {
        return $"{_commenterName}: {_comment}"; //changed to return a string - not void
    }
}