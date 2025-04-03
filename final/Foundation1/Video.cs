using System;
using System.Runtime.CompilerServices;

public class Video
{
    //variables
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments;
    private string _amount;
    
    //constructor
    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
        //set comments to an empty list so I can append items to it.
        _comments = [];
    }

    //external uses (returns something)
    public string AssembleDetails()
    {
        //this holds the formatting for the information of the video
        string details = $"{_title} - {_author}{Environment.NewLine}Duration: {_length}(s) - Comments: {_amount}";
        return details;
    }

    //getters and setters
    public void AppendComments(Comment formattedComment)
    {
        _comments.Add(formattedComment);
    }        

    public void CountComments()
    {
        int num = _comments.Count();
        _amount = num.ToString();
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public string GetAmount()
    {
        return _amount;
    }
}