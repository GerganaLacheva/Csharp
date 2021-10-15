using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            
            products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }

        }
    }
}
//4.List of Products
//Read a number n and n lines of products. Print a numbered list of all the products ordered by name.
//Examples
//Input	
//4
//
//Output
//Potatoes
//Tomatoes
//Onions
//Apples	1.Apples
//2.Onions
//3.Potatoes
//4.Tomatoes
