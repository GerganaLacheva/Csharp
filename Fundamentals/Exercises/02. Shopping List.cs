using System;
using System.Collections.Generic;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = new List<string>(Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries));
            string command = Console.ReadLine();
            while (command != "Go Shopping!")
            {
                string[] commandTempArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandTempArr[0];
                switch (currentCommand)
                {
                    case "Urgent":
                        string item = commandTempArr[1];
                        if (!shops.Contains(item))
                        {
                            shops.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        string unnecenssaryItem = commandTempArr[1];
                        if (shops.Contains(unnecenssaryItem))
                        {
                            shops.Remove(unnecenssaryItem);
                        }
                        break;
                    case "Correct":
                        string oldItem = commandTempArr[1];
                        string newItem = commandTempArr[2];
                        if (shops.Contains(oldItem))
                        {
                            int index = shops.IndexOf(oldItem);
                            shops.Insert(index, newItem);
                            shops.Remove(oldItem);
                        }
                        break;
                    case "Rearrange":
                        string rearrangeItem = commandTempArr[1];
                        if (shops.Contains(rearrangeItem))
                        {
                            shops.Remove(rearrangeItem);
                            shops.Add(rearrangeItem);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", shops));
        }
    }
}
//You will receive an initial list with groceries separated by an exclamation mark "!".
//After that, you will be receiving 4 types of commands until you receive "Go Shopping!".
//•	"Urgent {item}" - add the item at the start of the list.  If the item already exists, skip this command.
//•	"Unnecessary {item}" - remove the item with the given name, only if it exists in the list. Otherwise, skip this command.
//•	"Correct {oldItem} {newItem}" - if the item with the given old name exists, change its name with the new one.Otherwise, skip this command.
//•	"Rearrange {item}" - if the grocery exists in the list, remove it from its current position and add it at the end of the list.Otherwise, skip this command.
//Constraints
//•	There won't be any duplicate items in the initial list
//Output
//•	Print the list with all the groceries, joined by ", ":
//"{firstGrocery}, {secondGrocery}, … {nthGrocery}"
//Examples
//Input   Output
//Tomatoes!Potatoes!Bread
//Unnecessary Milk
//Urgent Tomatoes
//Go Shopping!	Tomatoes, Potatoes, Bread
//Input   Output
//Milk!Pepper!Salt!Water!Banana
//Urgent Salt
//Unnecessary Grapes
//Correct Pepper Onion
//Rearrange Grapes
//Correct Tomatoes Potatoes
//Go Shopping!	Milk, Onion, Salt, Water, Banana
