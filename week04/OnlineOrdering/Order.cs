using System.Security.Cryptography.X509Certificates;

public class Order
{

    public List<Product> _products;
    Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;

    }



    public float SubTotal()
    {
        float subTotal = 0;

        foreach (Product product in _products)
        {
            subTotal += product.GetTotalCost();
        }

        return subTotal;
    }



    float GetShipping()
    {

        return _customer.isUSA() ? 5 : 35;
    }


    public float TotalCost()
    {
        float totalCost = SubTotal();

        totalCost += GetShipping();


        return totalCost;
    }


    public string GetPackingLabel()
    {

        string packingLabel = "";

       
        foreach (Product product in _products)
        {
           
            packingLabel +=
    $"Name: {product.Getname()}  Product Id: {product.GetProductId()};  Price: {product.GetPrice()}; Quantity: {product.GetQuantity()}; Total Cost: {product.GetTotalCost()}\n";


        }

        return packingLabel;
    }




}