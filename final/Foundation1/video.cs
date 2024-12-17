using System;


public class Video 
{
    
    public string _title;
    public string _author;
    public int _length;

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
 
