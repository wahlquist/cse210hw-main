using System;

public class Dock
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Write> _entries = new List<Write>();
 
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Write day in _entries)
        {
            // This calls the Display method on each job
            day.Display();
        }
    }
}