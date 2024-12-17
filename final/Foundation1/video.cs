using System;


public class Video 
{
    
    private string _title;
    private string _author;
    private int _length;

public  Video(string title, string author, int length)
{
_title = title;
_author = author;
_length = length;
}
public List<Comment> _comments = new List<Comment>();

public void Display()
{
    Console.WriteLine("");
    Console.WriteLine($" title:  {_title}     author:  {_author} length   {_length}  ");
    int count = _comments.Count();

        Console.WriteLine($"There are {count} comments");
    foreach (var responce in _comments)
    {
        responce.Display();
    }
}



}
 
