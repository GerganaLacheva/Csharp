using System;
using System.Collections.Generic;
using System.Linq;

namespace EX07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine().Split("|");                //четем входа като го разделяме на три отделни масива, разделени по "|"
            List<string> newArray = new List<string>();                     //създаваме празен лист, в който ще записваме елементите след трансформацията

            for (int i = arrays.Length - 1; i >= 0; i--)                    //създаваме намаляващ фор, за да ги подредим в обратен ред по условие
            {
                string[] elements = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);    //сплитваме всеки от отделните масиви по "  ", за да можем да премахнем излишните спейсове
                newArray.AddRange(elements);                                //добавяме обработените масиви в празния лист
            }

            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
//7.Append Arrays
//Create a program to append several arrays of numbers one after another.
//•	Arrays are separated by '|'
//•	Their Values are separated by spaces (' ', one or several)
//•	Take all arrays starting from the rightmost and going to the left and place them in a new array in that order
//Examples
//Input	                    Output
//1 2 3 |4 5 6 |  7  8	    7 8 4 5 6 1 2 3
//7 | 4  5|1 0| 2 5 |3	    3 2 5 1 0 4 5 7
//1| 4 5 6 7  |  8 9	        8 9 4 5 6 7 1
