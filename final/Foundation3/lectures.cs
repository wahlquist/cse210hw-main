public class Lectures : Event
{
private string _speaker;
private string _capacity;


    public Lectures (string title, string topic,string date, string time, string address,string speaker,string capacity )
    :base (title, topic, date,time,address)
{
_speaker = speaker;
_capacity=capacity;
}
public string Gettalk()
    {
        return $"Speaker: {_speaker} The speakers background is {_capacity}";
    }

}