


using System.Reflection.Metadata;

public class Customer 
{
    public Customer(string name, bool usa)
    { 
        _name = name;
        _usa= usa;
        
    }
private string _name;

private bool _usa;
private Address _address;
public bool InAmerica()
{
    return _usa;
}
public string GetName()
{
    return _name;
}

public void SetAdress(Address a)
{
    _address = a;
}
public void Display()
{
    _address.Display();
    Console.WriteLine(_name);
}
}