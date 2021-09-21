using System;

namespace _08._Divisible_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //    for (int i = 1; i < 100; i++)
            //    {
            //        if (i%3==0)
            //        {
            //        Console.WriteLine(i);
            //        }
            //    }

            for (int i = 3; i < 100; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
//8.Divisible by 3
//Create a program, which prints all the numbers from 1 to 100, that is divisible by 3. You have to use a single for loop. The program should not receive input.
