using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
     public List<Product> products = new List<Product>();

   
   
   
   
    Address address = new("200 Main Stree", "Minneapolis", "Minnesota", "USA");

    Customer customer = new("John Doe", Address);

    Order order = new Order(products, customer,);


}


}

