// _task:string
// _points:int
// _description:string
// _Xbox:bool
using System;
using System.Dynamic;


// GetGoals()void display
// TaskSet():string
// TaskGet():string
// PointsSet():int
// PointsGet():int
// DescriptionSet():string
// DescriptionGet():string
// TaskSet():string
// TaskGet():string
// GetXbox():Bool
// SetXbox():Bool
public abstract class  NewGoal 
{
    List<NewGoal> _goals = new List<NewGoal>();
private string _task;
private int _points;
private string _description;
private bool _Xbox;
public NewGoal(string task, int points,string description,bool Xbox)
    {
        _task=task;
        _points=points;
        _description=description;
        _Xbox=Xbox;
    }
 public void AddSimple(Simple product)
    {
        _goals.Add(product);
    }

// public void GetGoals ()
// {            int  option = 0;
// Console.WriteLine("What type of goal? ");
// Console.WriteLine("    1.   simple ");
// Console.WriteLine("    2.   eternal ");
// Console.WriteLine("    3.   checklist");
// if (int.TryParse(Console.ReadLine(), out option))
//     {       Console.WriteLine("task");  
//              _task = Console.ReadLine();
//             Console.WriteLine("discription");  
//              _description = Console.ReadLine();
//             Console.WriteLine("points");
//             _points = int.Parse(Console.ReadLine());
    
//     if (option == 1)
    
//         {
           
            
          
//         }
//     else if (option== 2)
//         {
           
//         }
//     else if (option==3)
//     {

//     }}

    

// Console.WriteLine("What will be your goal");
// _task = Console.ReadLine();
// Console.WriteLine("How many points will it be? ");
// string input = Console.ReadLine();

public abstract int GetPoints();
public abstract string GetDescription();
public abstract string GetTask();
public abstract bool GetXbox();




}













