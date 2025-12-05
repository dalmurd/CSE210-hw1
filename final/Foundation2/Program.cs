using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("671 Lincoln Avenue", "Winnetka", "IL", "USA");
        Address address2 = new Address("74 Church Lane", "Dumfries", "DG24 3YA", "UK");

        Customer customer1 = new Customer("Harry and Marv", address1);
        Customer customer2 = new Customer("Collin Furze", address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        order1.AddProduct(new Product("Red Rider BB Gun", 1001988, 30.0, 1));
        order1.AddProduct(new Product("Tar Buckets", 1002334, 15.25, 2));
        order1.AddProduct(new Product("Flamethower", 100911, 25.50, 1));
        order2.AddProduct(new Product("Electric Motor", 1500999, 115.75, 2));
        order2.AddProduct(new Product("Stainless Steel Box Section 2x4", 1502345, 5.50, 16));
        order2.AddProduct(new Product("Tyres", 1506784, 10.00, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order Total: ${order1.GetOrderTotal()}");
        Console.WriteLine("---------------------------");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order Total: ${order2.GetOrderTotal()}");
        Console.WriteLine("---------------------------");
    }
}