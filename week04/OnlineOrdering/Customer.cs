public class Customer
{
    private string _name;
    private Address _address;

public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool CheckCountry()
    {
        return _address.IsFromUsa();
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}