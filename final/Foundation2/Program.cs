using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Video Graphics Card GT1030", 1, 119.99, 1);
        Product product2 = new Product("Water Colling Elite", 2, 289.99, 2);
        Product product3 = new Product("Memory Ram 8gb", 3, 104.99, 4);
        Product product4 = new Product("Computer Case RGB", 4, 199.99, 1);

        Address address1 = new Address("456 Oak Avenue", "Coeur d'Alene", "Idaho", "USA");
        Address address2 = new Address("789 Yonge Street", "Toronto", "Ontario", "Canada");

        Customer customer1 = new Customer("Michael Felpeira", address1);
        Customer customer2 = new Customer("Will Jordan", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1, 2);
        order1.AddProduct(product2, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2, 1);
        order2.AddProduct(product4, 4);

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalCost());
        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalCost());

        Console.ReadLine();
    }
}