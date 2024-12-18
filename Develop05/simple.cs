// _complete
// SetPoints(_points:int):int
// Void Display()

public class Simple:NewGoal
{


public Simple(string date, int length, string distance,bool Xbox) : base (date,length,distance,Xbox)
    {
        
        
    }



public override int GetPoints()
    {
        return 5;
    }
public override string GetDescription()
    {
        return "5";
    }
public override string GetTask()
    {
        return "5";
    }
public override bool GetXbox()
    {
        return true;
    }
}