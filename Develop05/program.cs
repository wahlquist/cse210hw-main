using System;

class Program
{
  public static List<NewGoal> _goals = new List<NewGoal>();

 static void Main(string[] args)
  {
// List<NewGoal> _goals = new List<NewGoal>();
        int  menuselect = 0;
       while (menuselect != 6)
       {
    Console.WriteLine("Menu Options");

    Console.WriteLine("    1.  Create New Goal");
    Console.WriteLine("    2.  List Goal");
    Console.WriteLine("    3.  Save Goal");
    Console.WriteLine("    4.  Load Goals");
    Console.WriteLine("    5.  Record Event");
    Console.WriteLine("    6.  Quit");
    menuselect=int.Parse(Console.ReadLine());


    if (menuselect==1)
    {Console.WriteLine("what would you like to do");
           int  option = 0;
Console.WriteLine("What type of goal? ");
Console.WriteLine("    1.   simple ");
Console.WriteLine("    2.   eternal ");
Console.WriteLine("    3.   checklist");
if (int.TryParse(Console.ReadLine(), out option))
          Console.WriteLine("task");  
            string task = Console.ReadLine();
            Console.WriteLine("discription");  
            string description = Console.ReadLine();
            Console.WriteLine("points");
            int points = int.Parse(Console.ReadLine());
        
        //    Order order = new Order();
    if (option == 1)
    
        {
           Simple t1 = new Simple(task, points, description,false);
            
          
        }
    else if (option== 2)
        {
           Eternal t2 = new Eternal(task,points,description,false);
           _goals.Add(t2);
        }
    else if (option==3)
    {
        Console.WriteLine("how many times would you like to do this task?");
        int howmany= int.Parse(Console.ReadLine());
            Checklist t3 = new Checklist(task,points,description,false,howmany,0);
            _goals.Add(t3);
    }}
   
        
    else if (menuselect== 2)
        {
           
        }
    else if (menuselect==3)
    {
        string filePath = "goals.txt";
        // File.AppendAllLines(filePath,  );
    }
    else if (menuselect ==4)
    {

    }
    else if (menuselect ==5)
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal);
        }
    }

 }




      }
}