using System;

class Program
{
    static void Main(string[] args)
    {
        Address usa = new Address("123 Main St", "Provo", "UT", "USA");
        Address canada = new Address("456 Queen St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", usa);
        Customer customer2 = new Customer("Jane Smith", canada);

        Order order1 = new Order(customer1);
        order1.AddProduct("Laptop", 101, 799.99, 2);
        order1.AddProduct("Mouse", 102, 25.50, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct("Monitor", 201, 299.99, 1);
        order2.AddProduct("USB Cable", 202, 12.99, 5);

        order1.DisplayOrder();
        Console.WriteLine("=============================");
        order2.DisplayOrder();
    }
}