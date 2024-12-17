public class Cycling: Activity
{
private double _speed;

public Cycling(string date, double length, double speed) : base (date,length)
    {
        _speed = speed;
    }

    // Notice the use of the override keyword here
    
    public override double GetDistance()
    {
        double length =GetTime();
        return _speed * length ;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60/_speed;
    }




}