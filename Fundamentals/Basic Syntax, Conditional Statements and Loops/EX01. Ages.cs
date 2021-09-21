using System;

namespace EX01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            switch (age)
            {
                case int num when num <= 2:
                    Console.WriteLine("baby");
                    break;
                case int num when num > 2 && num <= 13:
                    Console.WriteLine("child");
                    break;
                case int num when num > 13 && num <= 19:
                    Console.WriteLine("teenager");
                    break;
                case int num when num > 19 && num <= 65:
                    Console.WriteLine("adult");
                    break;
                default:
                    Console.WriteLine("elder");
                    break;
            }

            //if (age <= 2)
            //{
            //    Console.WriteLine("baby");
            //}
            //else if (age > 2 && age <= 13)
            //{
            //    Console.WriteLine("child");
            //}
            //else if (age > 13 && age <= 19)
            //{
            //    Console.WriteLine("teenager");
            //}
            //else if (age > 19 && age <= 65)
            //{
            //    Console.WriteLine("adult");
            //}
            //else
            //{
            //    Console.WriteLine("elder");
            //}
        }
    }
}
//1.Ages
//Write a program that determines whether based on the given age a person is: baby, child, teenager, adult, elder.The bounders are:
//•	0 - 2 – baby; 
//•	3 - 13 – child; 
//•	14 - 19 – teenager;
//•	20 - 65 – adult;
//•	>= 66 – elder; 
//•	All the values are inclusive.
//Examples
//Input	Output
//20	adult
//1	baby
//100	elder
