public abstract class Activity
{
private string _date;
public double _length;




    public Activity(string date, double length)
    {
        _date = date;
        _length =length;
    }

    public string GetColor()
    {
        return _date;
    }
    public double GetTime()
    {   
        return _length;
    }
    public void SetTime(double length)
    {
        _length = length;
    }
    public void SetColor(string date)
    {
        _date = date;
    }

    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    



}