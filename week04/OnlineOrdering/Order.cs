using System.Reflection.Emit;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(string name, int productId, double price, int quantity)
    {
        Product product = new Product(name, productId,price,quantity);
        _products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;
        foreach(Product product in _products)
        {
            total += product.TotalCost();
        }

        total += ShippingCost();

    return total;

    }

    public double ShippingCost()
    {
        if (_customer.CheckCountry())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string PackingLabel()
    {
        string label = "________________________________________\n";

        foreach(Product product in _products)
        {
            label += $"Product: {product.GetName()}\nProduct ID: {product.GetId()}\nQuantity: {product.GetQuantity()}\nTotal: {product.TotalCost()}\n________________________________________\n";
        }

        return label;
    }

    public string ShippingLabel()
    {
        string label = $"============================\nCustomer: {_customer.GetCustomerName()}\n Address: {_customer.GetAddress()}";

        return label;
    }

    public void DisplayOrder()
    {
        Console.WriteLine(PackingLabel());
        Console.WriteLine(ShippingLabel());
        Console.WriteLine($"Shipping Cost: ${ShippingCost()}");
        Console.WriteLine($"\nTotal Order: ${TotalCost():F2}");
    }
    
}