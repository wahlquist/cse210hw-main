public class Swimming: Activity
{
private double _laps;


public Swimming(string date, double length, double laps) : base (date,length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps *50/1000 ;
    }
    public override double GetSpeed()
    {
        return _laps *50/1000/_length;
    }
    public override double GetPace()
    {
        return 60/(_laps *50/1000/_length);
    }

    
}