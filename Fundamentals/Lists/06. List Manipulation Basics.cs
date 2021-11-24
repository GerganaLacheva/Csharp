using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command!="end")
            {
                string[] commandArguments = command.Split();
                string action = commandArguments[0];
                int element = int.Parse(commandArguments[1]);

                if (action== "Add")
                {
                    numbers.Add(element);
                }
                else if (action== "Remove")
                {
                    numbers.Remove(element);
                }
                else if (action== "RemoveAt")
                {
                    numbers.RemoveAt(element);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArguments[2]);
                    numbers.Insert(index, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
//6.List Manipulation Basics
//Create a program that reads a list of integers. Then until you receive "end", you will receive different commands:
//•	Add
//{ number}: add a number to the end of the list.
//•	Remove {number}: remove a number from the list.
//•	RemoveAt {index}: remove a number at a given index.
//•	Insert {number} { index}: insert a number at a given index.
//Note: All the indices will be valid!
//When you receive the "end" command, print the final state of the list (separated by spaces).
//Example
//Input	
//4 19 2 53 6 43
//Add 3
//Remove 2
//RemoveAt 1
//Insert 8 3
//end	
//
//Output
//4 53 6 8 43 3
