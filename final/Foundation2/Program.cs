using System;

class Program
{
    static void Main(string[] args)
    {
        
    Product product1 = new Product();
    product1._name ="socks";
    product1._productId ="1543";
    product1._unitprice =5;
    product1._quantity =2;
   
    Product product2 = new Product();
    product2._name ="shoes";
    product2._productId ="1543";
    product2._unitprice =20;
    product2._quantity =1;
    
    Customer customer1 = new Customer("jared",true);
    // customer1._name = "jared";
    // customer1._usa = true;


    Address address1 = new Address();
    address1._usa = true;
    address1._street = "8077 galent green";
    address1._city = "king george";
    address1._country = "USA";
    address1._state = "virginia";

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