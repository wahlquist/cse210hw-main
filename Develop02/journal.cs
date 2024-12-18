using System;


public class Journal{
    public List<Write> _entries;

    public void AddEntry(Write entry){
        _entries.Add(entry);
    }
}