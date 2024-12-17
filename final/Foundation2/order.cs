


using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

public class Order
{

// public  List<Customer> _customers =new List <Customer> ();
public   List<Customer> _customers =new List <Customer>();
public  List<Product> _products =new List <Product> ();
// public void GetLists()
// {

// }
public void AddCustomer(Customer customer)
{
_customers.Add(customer);
 }
// public void AddProduct(Product.Getsubtotal(int _unitprice, int _quantity))
// {
//     // _products.Add(product);
// }
 public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate and display the total cost of all products
    public void GetTotal()
    {
        bool chat = false;
        int total = 0;
        foreach (var customer in _customers)
            {
             chat = customer.InAmerica();
            }
        foreach (var product in _products)
        {
            total += product.Getsubtotal();
        }
       if (chat ==true)
    {
         total = total + 5;
      }
      else if (chat == false)
      {
         total = total +35;
      }
      Console.WriteLine($"Total Order Amount: {total}");
        }
        
    
//     
    // int money =Product.Getsubtotal(_unitprice, _quantity);

 
public List<int> numbers = new List<int> { };



// public int CalculateTotal()
// { 
    
//     List<int> legion = _products.Select(p => p._quantity).ToList();
//  List<int> prices = _products.Select(p => p._unitPrice).ToList();
// int bob = 0;
//     foreach (var person in _customers)
//     {
//         Console.WriteLine(person);
//     }
//      foreach (var product in legion)
//      {
//          int howmany =legion[bob];
//     int howmuch = prices[bob];
//          Console.WriteLine($"{product}");
//          bob= bob+1;
//         int sum = howmany*howmuch;
//          numbers.Add(sum);
//      }
//     int quartertotal = 0;
//     foreach (var number in numbers)
//     {
//     quartertotal = quartertotal + number;
//     }
    
//     return quartertotal;
// }
// public void Display()
// { bool chat = false;

//     foreach (var customer in _customers)
//     {   
        
//         string cat =customer.GetName();
//         Console.WriteLine(cat);
//     } 
//     int child = CalculateTotal();
    
//     foreach (var customer in _customers)
//     { chat = customer.InAmerica();
//        if (chat ==true)
//      {
//         child = child + 5;
//      }
//      else if (chat == false)
//      {
//         child = child +35;
//      }
//     Console.WriteLine($"{child}");

    
}

// }}