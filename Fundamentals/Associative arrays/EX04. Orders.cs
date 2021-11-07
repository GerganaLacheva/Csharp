using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] inputInfo = input.Split();
                string productName = inputInfo[0];
                double productPrice = double.Parse(inputInfo[1]);
                double productQty = double.Parse(inputInfo[2]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new double[2]);
                }

                double previousQty = products[productName][1];
                double[] priceQty = new double[] { productPrice, previousQty + productQty };
                products[productName] = priceQty;

                input = Console.ReadLine();
            }
            foreach (var productKvp in products)
            {
                double totalPrice = productKvp.Value[0] * productKvp.Value[1];
                Console.WriteLine($"{productKvp.Key} -> {totalPrice:f2}");
            }
        }
    }
}
//4.Orders
//Create a program that keeps the information about products and their prices. Each product has a name, a price, and a quantity. If the product doesn’t exist yet, add it with its starting quantity.
//If you receive a product, which already exists, increases its quantity by the input quantity and if its price is different, replace the price as well.
//You will receive products’ names, prices, and quantities on new lines.Until you receive the command "buy", keep adding items. When you do receive the command "buy", print the items with their names and the total price of all the products with that name.
//Input
//•	Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
//•	The product data is always delimited by a single space.
//Output
//•	Print information about each product in the following format: 
//"{productName} -> {totalPrice}"
//•	Format the average grade to the 2nd digit after the decimal separator.
//Examples
//Input	
//Beer 2.20 100
//IceTea 1.50 50
//NukaCola 3.30 80
//Water 1.00 500
//buy	
//
//Output
//Beer -> 220.00
//IceTea -> 75.00
//NukaCola -> 264.00
//Water -> 500.00
