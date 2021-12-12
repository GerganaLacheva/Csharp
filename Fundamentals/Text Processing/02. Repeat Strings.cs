using System;
using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();

            foreach (var item in input)
            {
                int count=item.Length;
                for (int i = 0; i < count; i++)
                {
                    result.Append(item);
                }
            }
            Console.WriteLine(result);
        }
    }
}
//2.Repeat Strings
//Write a Program That Reads an Array of Strings. Each String is Repeated N Times, Where N is the Length of the String. Print the Concatenated String.
//Examples
//Input	            Output
//hi abc add	    hihiabcabcabcaddaddadd
//work	            workworkworkwork
//ball	            ballballballball
