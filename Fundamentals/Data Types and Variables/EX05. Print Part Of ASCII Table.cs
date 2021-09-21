using System;

namespace EX05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInput = int.Parse(Console.ReadLine());
            int endInput = int.Parse(Console.ReadLine());

            for (int i = startInput; i <= endInput; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
