using System;

namespace EX04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < input; i++)
            {
                string symbols = Console.ReadLine();
                sum += symbols [0];
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
