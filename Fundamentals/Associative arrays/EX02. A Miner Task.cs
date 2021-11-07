using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();

            string input = Console.ReadLine();

            bool isOdd = true;
            string currentResource = string.Empty;

            while (input != "stop")
            {
                if (isOdd)
                {
                    if (!resourses.ContainsKey(input))
                    {
                        resourses.Add(input, 0);
                    }

                    currentResource = input;
                    isOdd = false;
                }
                else
                {
                    int value = int.Parse(input);

                    resourses[currentResource] += value;
                    isOdd = true;
                }

                input = Console.ReadLine();
            }

            foreach (var resource in resourses)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
//2.A Miner Task
//You will be given a sequence of strings, each on a new line.Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on) and every even - quantity. Your task is to collect the resources and print them each on a new line.
//Print the resources and their quantities in the following format:
//"{resource} –> {quantity}"
//The quantities will be in the range [1 … 2 000 000 000]
//Examples
//Input	        Output		
//Gold            Gold -> 155
//155             Silver -> 10
//Silver          Copper -> 17
//10
//Copper
//17
//stop	
		
//Input	        Output
//gold            gold -> 170
//155             silver -> 10
//silver          copper -> 17
//10
//copper
//17
//gold
//15
//stop	


