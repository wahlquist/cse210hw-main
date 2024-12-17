using System;

class Program
{
    static void Main(string[] args)
    {
        
    Product product1 = new Product("socks","1543",5,2);

    Product product2 = new Product("shoes","1543",20,1);
 
    Customer customer1 = new Customer("jared",true);
 


    Address address1 = new Address(true,"8077 galent green","king george","USA","virginia");


    Order order = new Order();
    order.AddCustomer(customer1);
    customer1.SetAdress(address1);

    order.AddProduct(product1);
    order.AddProduct(product2);
    // order.Display();
    customer1.Display();
    product1.GetProduct();
    product2.GetProduct();
    order.GetTotal();

    }
}