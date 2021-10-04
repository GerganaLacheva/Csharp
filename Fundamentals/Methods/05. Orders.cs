using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Order(product, quantity);
        }
        static void Order(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee": price= 1.5; break;
                case "water": price= 1.0; break;
                case "coke": price= 1.4; break;
                case "snacks": price= 2.0; break;
            }
            double totalPrice = price * quantity;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
//5.Orders
//Create a method that calculates the total price of an order and prints it to the console. The method should receive one of the following products: coffee, coke, water, snacks, and of the quantity of the product.
//The prices for a single item of each product are:
//•	coffee – 1.50
//•	water – 1.00
//•	coke – 1.40
//•	snacks – 2.00
//Print the result rounded to the second decimal place.
//Example
//Input	    Output
//water     5.00
//5	
