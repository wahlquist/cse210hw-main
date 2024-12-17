public class Gatherings : Event
{
    private string _weather;
    public Gatherings (string title, string topic,string date, string time, string address,string weather )
      :base (title, topic, date,time,address)
      {
        _weather = weather;
      }
      public string Getstatement()
    {
        return $" {_weather} ";
    }

}
