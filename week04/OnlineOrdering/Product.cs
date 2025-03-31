public class Product
{

    private string _name;

    private int _productId;
    private float _price;
    private int _quantity;

    public string Getname()
    {

        return $"{_name}";
    }

    public int GetProductId()
    {

        return _productId;
    }


    public int GetQuantity()
    {

        return _quantity;
    }


    public float GetPrice()
    {

        return _price;
    }

    public float GetTotalCost()
    {

        return _price * _quantity;


    }




    public Product(string name, int productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    


}



}