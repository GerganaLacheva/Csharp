using System;

namespace MEX01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          //first solution:
          
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());
            //int largest = Math.Max(Math.Max(n1, n2), n3);
            //int smallest = Math.Min(Math.Min(n1, n2), n3);
            //int middle = (n1 + n2 + n3) - (largest + smallest);
            //Console.WriteLine(largest);
            //Console.WriteLine(middle);
            //Console.WriteLine(smallest);

            //second solution:

            int[] intArray = new int[3]; // създаване на масив от три елемента

            for (int i = 0; i < intArray.Length; i++) // задаване на итерации=размера на масива
            {
                intArray[i] = int.Parse(Console.ReadLine()); // четене на нов вход от конзолата
            }
            Array.Sort(intArray); // сортиране във възходящ ред
            Array.Reverse(intArray); // сортиране в низходящ ред

            for (int x = 0; x < intArray.Length; x++)
            {
                Console.WriteLine(intArray[x]); // принтиране на конзолата
            }
        }
    }
}
//1.Sort Numbers
//Read three real numbers and sort them in descending order. Print each number on a new line.
