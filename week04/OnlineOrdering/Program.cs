using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address(
            "123 Main St",
            "Phoenix",
            "AZ",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "A123", 800, 1));
        order1.AddProduct(new Product("Mouse", "B456", 20, 2));


        Address address2 = new Address(
            "Avenida Siempre Viva 742",
            "Lima",
            "Lima",
            "Peru"
        );

        Customer customer2 = new Customer("Carlos Pérez", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Keyboard", "K999", 50, 1));
        order2.AddProduct(new Product("Monitor", "M222", 150, 1));
        order2.AddProduct(new Product("USB Cable", "U777", 5, 3));


        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    
    }
}