


public class Product 
{

private string _name;
private string _productId;
private int _unitprice;
private int _quantity;

 public Product(string name, string productId, int unitprice, int quantity)
 {
_name=name;
_productId=productId;
_unitprice=unitprice;
_quantity=quantity;
 }

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