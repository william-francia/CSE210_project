using System;
using System.Collections.Generic;

public class Video
{
    private string _VideoTitle;
    private string _Author;
    private double _Duration;

    private List<Comment> ListComments = new List<Comment>();

    public Video(string videoTitle, string author, double duration)
    {
        _VideoTitle = videoTitle;
        _Author = author;
        _Duration = duration;
    }

    public void AddComment(Comment comment)
    {
        ListComments.Add(comment);
    }

    public int NumberOfComment()
    {
        return ListComments.Count;
    }
    public string GetTitle()
    {
        return _VideoTitle;
    }

    public string GetAuthor()
    {
        return _Author;
    }

    public double GetDuration()
    {
        return _Duration;
    }

    public List<Comment> GetComments()
    {
        return ListComments;
    }



}