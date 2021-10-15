using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> input2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> merged = new List<int>();

            int biggerInput = input1.Count;

            if (biggerInput < input2.Count)
            {
                biggerInput = input2.Count;
            }

            for (int i = 0; i < biggerInput; i++)
            {
                if (input1.Count > i)
                {
                    merged.Add(input1[i]);
                }
                if (input2.Count>i)
                {
                merged.Add(input2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", merged));
        }
    }
}
//3.Merging Lists
//You are going to receive two lists of numbers. Create a list that contains the numbers from both of the lists. The first element should be from the first list, the second from the second list, and so on. If the length of the two lists is not equal, just add the remaining elements at the end of the list.
//Example
//Input	                        Output
//3 5 2 43 12 3 54 10 23
//76 5 34 2 4 12	                3 76 5 5 2 34 43 2 12 4 3 12 54 10 23
//76 5 34 2 4 12
//3 5 2 43 12 3 54 10 23	        76 3 5 5 34 2 2 43 4 12 12 3 54 10 23
