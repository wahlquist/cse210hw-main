


using System.Security.Authentication;

public class Address
{
private bool _usa;
private string _street;
private string _city;
private string _state;
private string _country;

public Address(bool usa, string street,string city, string state ,string country)
{
    _usa = usa;
    _street=street;
    _city = city;
    _state = state;
    _country = country;
    


}
public bool GetName()
{
    return _usa;
}
public void Display()
{
    Console.WriteLine($"Adress is {_street}, {_city} , {_state} , {_country}");
}


}