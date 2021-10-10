using System;
using System.Collections.Generic;
using System.Linq;

namespace EX02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] commandParts = command.Split();                //разделяме командата на части
                string action = commandParts[0];                        //действието за извършване винаги е на индекс 0 от командата

                if (action == "Delete")
                {
                    int element = int.Parse(commandParts[1]);
                    numbers.RemoveAll(n => n == element);

                    //този код замества ламбда израза в RemoveAll:
                    //while (true)      
                    //{
                    //    bool removed = numbers.Remove(element);
                    //    if (!removed)
                    //    {
                    //        break;
                    //    }
                    //}
                }
                else if (action == "Insert")
                {
                    int element = int.Parse(commandParts[1]);
                    int index = int.Parse(commandParts[2]);

                    numbers.Insert(index, element);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
//2.Change List
//Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
//Your program may receive the following commands:
//•	Delete
//{ element} – delete all elements in the array, which are equal to the given element.
//•	Insert {element} { position} – insert the element at the given position.
//You should exit the program when you receive the "end" command. Print all numbers in the array separated by a single whitespace.
//Examples
//Input	
//1 2 3 4 5 5 5 6
//Delete 5
//Insert 10 1
//Delete 5
//end	
    
//Output
//1 10 2 3 4 6

//Input
//20 12 4 319 21 31234 2 41 23 4
//Insert 50 2
//Insert 50 5
//Delete 4
//end	
    
//Output 
//20 12 50 319 50 21 31234 2 41 23
