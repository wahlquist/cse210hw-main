


public class Product 
{

public string _name;
public string _productId;
public int _unitprice;
public int _quantity;


public int Getsubtotal()
{
    int number = _unitprice * _quantity;
    return number;
}


public void GetProduct ()
{
int sum = Getsubtotal();
Console.WriteLine($"your product is {_name}  ");
Console.WriteLine($"The product ID is: {_productId}  ");
Console.WriteLine($"${sum}");


}

}