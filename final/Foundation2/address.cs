


public class Address
{
public bool _usa;
public string _street;
public string _city;
public string _state;
public string _country;

public bool GetName()
{
    return _usa;
}
public void Display()
{
    Console.WriteLine($"Adress is {_street}, {_city} , {_state} , {_country}");
}


}