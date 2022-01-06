using System;
using System.Collections.Generic;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (!shops.ContainsKey(tokens[0]))
                {
                    shops[tokens[0]] = new Dictionary<string, double>();
                }
                shops[tokens[0]].Add(tokens[1], double.Parse(tokens[2]));


                command = Console.ReadLine();
            }
            foreach (var (key, value) in shops)
            {
                Console.WriteLine($"{key}->");
                foreach (var kvp in value)
                {
                    Console.WriteLine($"Product: {kvp.Key}, Price: {kvp.Value}");
                }
            }
        }
    }
}
//4.Product Shop
//Create a program that prints information about food shops in Sofia and the products they store. Until the "Revision" command is received, you will be receiving input in the format: "{shop}, {product}, {price}".Keep in mind that if you receive a shop you already have received, you must collect its product information.
//Your output must be ordered by shop name and must be in the format:
//"{shop}->
//Product: { product}, Price: { price}
//"
//Note: The price should not be rounded or formatted.
//Examples
//Input	
//lidl, juice, 2.30
//fantastico, apple, 1.20
//kaufland, banana, 1.10
//fantastico, grape, 2.20
//Revision	
//
//Output
//fantastico->
//Product: apple, Price: 1.2
//Product: grape, Price: 2.2
//kaufland->
//Product: banana, Price: 1.1
//lidl->
//Product: juice, Price: 2.3
