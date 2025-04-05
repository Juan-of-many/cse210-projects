using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<Product> productsAvailable = [];
        
        //create items
        Product product1 = new Product("frozen taco", "220", 4.99, 2);
        Product product2 = new Product("rice", "111", 45, 1);
        Product product3 = new Product("tomato", "008", 0.98, 7);
        Product product4 = new Product("cilantro", "006", 2.00, 2);
        Product product5 = new Product("black beans", "010", 4.00, 5);
        Product product6 = new Product("cheddar cheese", "034", 6.70, 1);
        Product product7 = new Product("bottled water (24 pc)", "540", 12.99, 1);
        Product product8 = new Product("twix bar", "311", 1.25, 1);
        Product product9 = new Product("wheat bread", "076", 8.00, 2);
        Product product10 = new Product("white bread", "077", 9.00, 1);
        
        //add all items
        productsAvailable.Add(product1);
        productsAvailable.Add(product2);
        productsAvailable.Add(product3);
        productsAvailable.Add(product4);
        productsAvailable.Add(product5);
        productsAvailable.Add(product6);
        productsAvailable.Add(product7);
        productsAvailable.Add(product8);
        productsAvailable.Add(product9);
        productsAvailable.Add(product10);
        
        //establish product lists for various orders
        List<Product> shoppingList1 = [productsAvailable[9], productsAvailable[8], productsAvailable[5]];
        List<Product> shoppingList2 = [productsAvailable[7], productsAvailable[0], productsAvailable[6]];
        List<Product> shoppingList3 = [productsAvailable[2], productsAvailable[3]];

        //establish customers with addresses to match the three above product lists
        Address address1 = new Address("1234 Bulbwood Ave.", "Crankston", "Georgia", "USA");
        Address address2 = new Address("34 Palace Embankment", "Saint Petersburg", "190000", "Russia");
        Address address3 = new Address("76 Sum Blv.", "Knoweresville", "Briarwood 32335", "UK");

        Customer c1 = new Customer("John Smith", address1);
        Customer c2 = new Customer("Catherine The Great", address2);
        Customer c3 = new Customer("George Washington", address3);

        //assign shopping list to each order
        Order order1 = new Order(shoppingList1, c1);
        Order order2 = new Order(shoppingList2, c2);
        Order order3 = new Order(shoppingList3, c3);

        //Call methods to get packing label, shipping label, total price of order, display results
        List<Order> orders = [];
        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);

        //go through each order and print info
        foreach (Order ord in orders)
        {
            double price = ord.CalculateOrderPrice();
            string packingLabel = ord.CreatePackingLabel();
            string shippingLabel = ord.CreateShippingLabel();
            

            //display info
            Console.WriteLine();
            Console.WriteLine(packingLabel);
            Console.WriteLine();
            Console.WriteLine("Your order's total price is: ");
            Console.WriteLine($"${price}");
            Console.WriteLine($"${ord.GetCostBeforeShipping()} cart price + ${ord.GetShippingCost()} for shipping");
            Console.WriteLine();
            Console.WriteLine(shippingLabel);
            Console.WriteLine();
        }
    }
}