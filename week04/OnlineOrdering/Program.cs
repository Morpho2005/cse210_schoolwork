using System;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order(new Customer("John", new Address("e 31st st", "New york city", "NY", "USA")));
        Order order1 = new Order(new Customer("San", new Address("s 21st st", "Tokyo", "Kanto", "Japan")));

        order.AddProduct("Apple", "APL", 3, 10);
        order.AddProduct("Chicken", "CKN", 15, 2);
        order.AddProduct("Bird Feed", "BDF", 1, 20);

        order1.AddProduct("Apple", "APL", 3, 15);
        order1.AddProduct("flour", "FLR", 8, 1);
        order1.AddProduct("Eggs", "EG", 6, 3);

        Console.WriteLine($"{order.GetPackingLabel()}, ${order.GetTotalPrice()}, {order.GetShippingLabel()}");

        Console.WriteLine($"{order1.GetPackingLabel()}, ${order1.GetTotalPrice()}, {order1.GetShippingLabel()}");
    }
}