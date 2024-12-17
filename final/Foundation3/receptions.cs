public class Reception : Event
{
private string _email;


public Reception (string title, string topic,string date, string time, string address,string email )
     :base (title, topic, date,time,address)
{
    _email= email;
}
public string GetMarried()
    {
        return $"Rsvp at {_email} ";
    }
}
