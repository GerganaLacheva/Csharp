using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();


            if (inputType == "int")
            {
                Console.WriteLine(GetMax(int.Parse(value1), int.Parse(value2)));
            }
            else if (inputType == "char")
            {
                Console.WriteLine(GetMax(char.Parse(value1), char.Parse(value2)));
            }
            else if (inputType == "string")
            {
                Console.WriteLine(GetMax(value1, value2));
            }
        }


        static int GetMax(int value1, int value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        static char GetMax(char value1, char value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        static string GetMax(string value1, string value2)
        {
            if (value1.CompareTo(value2) > 0)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
    }
}
//9.Greater of Two Values
//You are given an input of two values of the same type. The values can be of type int, char, or String. Create a method called getMax() that returns the parameter with the biggest value.
//Examples
//Input	Output
//int
//2
//16	    16
//char
//a
//z	        z
//string
//aaa
//bbb	    bbb
