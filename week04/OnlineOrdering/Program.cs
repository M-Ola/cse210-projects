using System;
//Author: Monsuru Oladipo: cse 210.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

           
            Address address1 = new Address("123 Main St", "Richfield", "MN", "USA");
            Address address2 = new Address("456 Elm St", "London", "England", "UK");

            
            Customer customer1 = new Customer("Alice Johnson", address1);
            Customer customer2 = new Customer("John Smith", address2);

          
            Product product1 = new Product("Laptop", 101, 999.99f, 1);
            Product product2 = new Product("Phone", 102, 699.99f, 2);
            Product product3 = new Product("Headphones", 103, 49.99f, 4);

            
            List<Product> productsForOrder1 = new List<Product> { product1, product2 };
            List<Product> productsForOrder2 = new List<Product> { product3 };

           
            Order order1 = new Order(productsForOrder1, customer1);
            Order order2 = new Order(productsForOrder2, customer2);

           
            Console.WriteLine("Order 1:");
            Console.WriteLine($"Customer: {customer1.GetCustomerName()}");
            Console.WriteLine($"Shipping Address: {customer1.GetAddress().GetAddress()}");
            Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
            Console.WriteLine($"SubTotal: {order1.SubTotal()}");
            Console.WriteLine($"Total Cost: {order1.TotalCost()}\n");

            Console.WriteLine("Order 2:");
            Console.WriteLine($"Customer: {customer2.GetCustomerName()}");
            Console.WriteLine($"Shipping Address: {customer2.GetAddress().GetAddress()}");
            Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
            Console.WriteLine($"SubTotal: {order2.SubTotal()}");
            Console.WriteLine($"Total Cost: {order2.TotalCost()}");
        }
    }










