


// _howmany:int
// _count:int




// SetPoints(_points:int):int
// Void Display()
public class Checklist:NewGoal
{
private int _howmany;
private int _count;


public Checklist( string date, int length, string distance,bool Xbox,int howmany,int count) : base (date,length,distance,Xbox)
    {
        _howmany = howmany;
        _count = count;
        
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