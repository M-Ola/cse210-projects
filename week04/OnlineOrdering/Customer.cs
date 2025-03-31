public class Customer
{
    private string _customerName;

    private Address _address;

    public string GetCustomerName()
    {
        return $"{_customerName}";


    }



    public Address GetAddress()
    {
        return _address;


    }

    public bool isUSA()
    {

        return _address.isUSA();
}

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    
}

}