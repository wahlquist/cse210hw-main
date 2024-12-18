using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Write
{
    public string _prompt;
    public string _write;
    public string _date;
  
     List<string> Prompts = new List<string> { "how did you see the hand of the lord", "how did you serve someone today", "what gospel lesson can you pull from today's events", "what was a significate interaction you made with another person", "what funny thing did you see today" };


 public string Prompt()
 {

        Random random = new Random();
        int randomIndex = random.Next(Prompts.Count); // Generates a random index between 0 and items.Count - 1

        _prompt = Prompts[randomIndex];

        Console.WriteLine(_prompt);
        return _prompt;
 }
public void storage( string write,string date)
{

_write = write;
_date= date;

} 
    

    public void Display()
    {
        Console.WriteLine($"Date:{_date} Prompt({_prompt})|: {_write}");
    }
}
