public  class Running :Activity 
{

private double _distance;


 public Running(string date, double length, double distance) : base (date,length)
    {
        _distance = distance;
        
    }


    public override double GetDistance()
    {
        return _distance ;
    }
    public override double GetSpeed()
    {
        double length =GetTime();
        return _distance/length;
    }
    public override double GetPace()
    {
        double length =GetTime();
        return 60/(_distance/length);
    }



}