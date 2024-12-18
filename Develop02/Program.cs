using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    
       public static List<string> _entries = new List<string> ();
       public static List<string> _dates = new List<string> ();
       public static List<string> _prompts = new List<string> ();
       public static List<int> _index = new List<int> ();
    static void Main(string[] args)
    {
  
        // Journal MyJournal = new Journal();
        // MyJournal._entries = new List<Write>();

        // int select = 0;
        // while (select != 5)
       {
        
        // Console.WriteLine("what would you like to do");
        // select = int.Parse(Console.ReadLine());
        // if (select = 1)
        } 

        int  menuselect = 0;
       while (menuselect != 5)
       {
   
    Console.WriteLine("1.  Write");
    Console.WriteLine("2.  Display");
    Console.WriteLine("3.  Load");
    Console.WriteLine("4.  Save");
    Console.WriteLine("5.  Quit");
    Console.WriteLine("");
    Console.WriteLine("what would you like to do");
    if (int.TryParse(Console.ReadLine(), out menuselect))
    {
    
    if (menuselect == 1)
    
        {
            Write write = new Write();
              List<string> _entry = new List<string>{};
            string _prompt = write.Prompt();
            string _write =Console.ReadLine();
            Console.WriteLine("what is the date today? ");
            string date= Console.ReadLine();
            write.storage(_write, date);
            _entries.Add(_write);
            _dates.Add(date);
            _prompts.Add(_prompt);
            

            // _write,date, _prompt 
            
            // write.Display();
        }
    else if (menuselect== 2)
        {
            int count= 0;
           foreach (var word in _entries)
             {

               _index.Add(count);
               count = count+1;
             }
             foreach (var i in _index )
             {
                  Console.WriteLine(_entries[i]);
                  Console.WriteLine(_dates[i]);
                  Console.WriteLine(_prompts[i]);
             }
            
        }}
    else if (menuselect==3)
    {
         string filePath = "journal.txt";
 foreach (var line in File.ReadLines(filePath))
        {
            Console.WriteLine(line);
        }
    }
    else if (menuselect ==4)
    {
        
        string filePath = "journal.txt";
        File.AppendAllLines(filePath, _entries);
        File.AppendAllLines(filePath, _dates);
        File.AppendAllLines(filePath, _prompts);

        Console.WriteLine("saved.");
    }}
        }
       
    }  

