using System;


public class Comment
{   
    private string _Author;
    private string _CommentText;

    public Comment (string author, string commenttext)
    {
        _Author = author;
        _CommentText = commenttext;
    }
    public string GetAuthor()
    {
        return _Author;
    }
    public string GetCommentText()
    {
        return _CommentText;
    }
}

