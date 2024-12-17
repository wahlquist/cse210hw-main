public class Event 
{


private string _title;
private string _description;
private string _date;
private string _time;
private string _address;



public Event (string studentName, string topic,string date, string time, string address)
    {
        _title = studentName;
        _description = topic;
        _date = date;
        _time = time;
        _address= address;
    }
 public string GetSummary()
    {
        return $"{_title}   {_date}     {_description}   {_address}    {_time}";
    }

}