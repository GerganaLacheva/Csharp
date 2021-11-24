using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandArguments = input.Split();
                string action = commandArguments[0];

                if (action == "exchange")
                {
                    int index = int.Parse(commandArguments[1]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }

                    Exchange(numbers, index);
                }
                else if (action == "max")
                {
                    int isEven = commandArguments[1] == "even" ? 0 : 1;
                    int index = GetMax(numbers, isEven);
                    PrintIndex(index);
                }
                else if (action == "min")
                {
                    int isEven = commandArguments[1] == "even" ? 0 : 1;
                    int index = GetMin(numbers, isEven);
                    PrintIndex(index);
                }
                else if (action == "first")
                {
                    int count = int.Parse(commandArguments[1]);
                    int isEven = commandArguments[2] == "even" ? 0 : 1;

                    if (count > numbers.Count || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                        input = Console.ReadLine();
                        continue;
                    }
                    List<int> elements = GetFirst(numbers, count, isEven);
                    PrintElements(elements);
                }
                else if (action == "last")
                {
                    int count = int.Parse(commandArguments[1]);
                    int isEven = commandArguments[2] == "even" ? 0 : 1;
                    if (count > numbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                        input = Console.ReadLine();
                        continue;
                    }
                    List<int> elements = GetLast(numbers, count, isEven);
                    PrintElements(elements);
                }


                input = Console.ReadLine();
            }
            PrintElements(numbers);
        }

        private static List<int> GetLast(List<int> numbers, int count, int isEven)
        {
            List<int> result = new List<int>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (result.Count == count)
                {
                    break;
                }
                if (numbers[i] % 2 == isEven)
                {
                    result.Add(numbers[i]);
                }
            }
            result.Reverse();
            return result;
        }

        private static void PrintElements(List<int> elements)
        {
            if (elements.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", elements)}]");
            }
        }

        private static List<int> GetFirst(List<int> numbers, int count, int isEven)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (count == result.Count)
                {
                    break;
                }
                if (numbers[i] % 2 == isEven)
                {
                    result.Add(numbers[i]);
                }
            }

            return result;
        }

        private static int GetMin(List<int> numbers, int isEven)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] < minNumber && numbers[i] % 2 == isEven)
                {
                    minNumber = numbers[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        private static void PrintIndex(int index)
        {
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        private static int GetMax(List<int> numbers, int isEven)
        {
            int maxIndex = -1;
            int maxNumber = int.MinValue;
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > maxNumber && numbers[i] % 2 == isEven)
                {
                    maxIndex = i;
                    maxNumber = numbers[i];
                }
            }
            return maxIndex;
        }

        private static void Exchange(List<int> numbers, int index)
        {
            for (int i = 0; i <= index; i++)
            {
                int currentElement = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(currentElement);
            }
        }
    }
}
//Array Manipulator
//Trifon has finally become a junior developer and has received his first task. It’s about manipulating an array of integers. He is not quite happy about it, since he hates manipulating arrays. They are going to pay him a lot of money, though, and he is willing to give somebody half of it if to help him do his job. You, on the other hand, love arrays (and money) so you decide to try your luck.
//The array may be manipulated by one of the following commands
//•	exchange {index} – splits the array after the given index, and exchanges the places of the two resulting sub-arrays. E.g. [1, 2, 3, 4, 5] -> exchange 2->result: [4, 5, 1, 2, 3]
//o If the index is outside the boundaries of the array, print "Invalid index"
//•	max even/odd – returns the INDEX of the max even/odd element -> [1, 4, 8, 2, 3] -> max odd -> print 4
//•	min even/odd – returns the INDEX of the min even/odd element -> [1, 4, 8, 2, 3] -> min even > print 3
//o	If there are two or more equal min/max elements, return the index of the rightmost one
//o	If a min/max even/odd element cannot be found, print "No matches"
//•	first {count} even / odd – returns the first {count} elements-> [1, 8, 2, 3]->first 2 even->print[8, 2]
//•	last
//{ count}
//even / odd – returns the last {count} elements-> [1, 8, 2, 3]->last 2 odd->print[1, 3]
//o If the count is greater than the array length, print "Invalid count"
//o	If there are not enough elements to satisfy the count, print as many as you can. If there are zero even/odd elements, print an empty array “[]”
//•	end – stop taking input and print the final state of the array
//Input
//•	The input data should be read from the console.
//•	On the first line, the initial array is received as a line of integers, separated by a single space
//•	On the next lines, until the command "end" is received, you will receive the array manipulation commands
//•	The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//•	The output should be printed on the console.
//•	On a separate line, print the output of the corresponding command
//•	On the last line, print the final array in square brackets with its elements separated by a comma and a space 
//•	See the examples below to get a better understanding of your task
//Constraints
//•	The number of input lines will be in the range [2 … 50].
//•	The array elements will be integers in the range [0 … 1000].
//•	The number of elements will be in the range [1 .. 50]
//•	The split index will be an integer in the range [-231 … 231 – 1]
//•	first / last count will be an integer in the range [1 … 231 – 1]
//•	There will not be redundant whitespace anywhere in the input
//•	Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.
//Examples
//Input	
//1 3 5 7 9
//exchange 1
//max odd
//min even
//first 2 odd
//last 2 even
//exchange 3
//end	
//
//Output
//2
//No matches
//[5, 7]
//[]
//[3, 5, 7, 9, 1]
//
//Input 
//1 10 100 1000
//max even
//first 5 even
//exchange 10
//min odd
//exchange 0
//max even
//min even
//end	
//
//Output
//3
//Invalid count
//Invalid index
//0
//2
//0
//[10, 100, 1000, 1]
//
//Input 
//1 10 100 1000
//exchange 3
//first 2 odd
//last 4 odd
//end	
//
//Output
//[1]
//[1]
//[1, 10, 100, 1000]
