using System;
using System.Linq;


namespace EX01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            
            int totalTravelers = 0;

            for (int i = 0; i < n; i++)
            {
                int travelers = int.Parse(Console.ReadLine());
                wagons[i]= travelers;
                totalTravelers += travelers;
                
            }
            Console.WriteLine(string.Join(" ",wagons));
            Console.WriteLine(totalTravelers);
        }
    }
}
//1.Train
//You will be given a count of wagons in a train n. On the next n lines you will receive how many people are going to get on each wagon.
//At the end print the whole train and after that, on the next line, the sum of the people in the train. 
//Examples
//Input	    Output
//3         13 24 8
//13
//24
//8	
//45
