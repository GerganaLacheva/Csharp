using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP01.Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] commandInfo = command.Split(">>>");
                string action = commandInfo[0];

                if (action == "Slice")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);
                    for (int i = endIndex - 1; i >= startIndex; i--)
                    {
                        input = input.Remove(i, 1);
                    }
                    Console.WriteLine(input);
                }
                else if (action == "Flip")
                {
                    string upperLower = commandInfo[1];
                    int startIndex = int.Parse(commandInfo[2]);
                    int endIndex = int.Parse(commandInfo[3]);

                    if (upperLower == "Upper")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            char currentChar = char.ToUpper(input[i]);
                            input = input.Remove(i, 1);
                            input = input.Insert(i, currentChar.ToString());
                        }
                    }
                    else
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            char currentChar = char.ToLower(input[i]);
                            input = input.Remove(i, 1);
                            input = input.Insert(i, currentChar.ToString());
                        }
                    }
                    Console.WriteLine(input);
                }
                else if (action == "Contains")
                {
                    string substring = commandInfo[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
//Problem 1 - Activation Keys
//Problem for exam preparation for the Programming Fundamentals Course @SoftUni.
//Submit your solutions in the SoftUni judge system at https://judge.softuni.org/Contests/Practice/Index/2302#0.

//You are about to make some good money, but first, you need to think of a way to verify who paid for your product and who didn't. You have decided to let people use the software for a free trial period and then require an activation key to continue using the product. Before you can cash out, the last step is to design a program that creates unique activation keys for each user. So, waste no more time and start typing!
//The first line of the input will be your raw activation key. It will consist of letters and numbers only. 
//After that, until the "Generate" command is given, you will be receiving strings with instructions for different operations that need to be performed upon the raw activation key.
//There are several types of instructions, split by ">>>":
//•	"Contains>>>{substring}":
//o If the raw activation key contains the given substring, prints: "{raw activation key} contains {substring}".
//o Otherwise, prints: "Substring not found!"
//•	"Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}":
//o Changes the substring between the given indices (the end index is exclusive) to upper or lower case and then prints the activation key.
//o	All given indexes will be valid.
//•	"Slice>>>{startIndex}>>>{endIndex}":
//o Deletes the characters between the start and end indices (the end index is exclusive) and prints the activation key.
//o	Both indices will be valid.
//Input
//•	The first line of the input will be a string consisting of letters and numbers only. 
//•	After the first line, until the "Generate" command is given, you will be receiving strings.
//Output
//•	After the "Generate" command is received, print:
//o "Your activation key is: {activation key}"
//Examples
//Input	
//abcdefghijklmnopqrstuvwxyz
//Slice>>>2>>>6
//Flip>>>Upper>>>3>>>14
//Flip>>>Lower>>>5>>>7
//Contains>>>def
//Contains>>>deF
//Generate	
//
//Output
//abghijklmnopqrstuvwxyz
//abgHIJKLMNOPQRstuvwxyz
//abgHIjkLMNOPQRstuvwxyz
//Substring not found!
//Substring not found!
//Your activation key is: abgHIjkLMNOPQRstuvwxyz
//Comments
//1.	Slice>>2>>6 
//abcdefghijklmnopqrstuvwxyz becomes abghijklmnopqrstuvwxyz
//2.	Flip>>>Upper>>>3>>>14
//abghijklmnopqrstuvwxyz becomes abgHIJKLMNOPQRstuvwxyz
//3.	Flip>>>Lower>>>5>>>7
//abgHIJKLMNOPQRstuvwxyz becomes abgHIjkLMNOPQRstuvwxyz
//4.	Contains>>>def
//abgHIjkLMNOPQRstuvwxyz does not contain def
//5.	Contains>>>deF
//abgHIjkLMNOPQRstuvwxyz does not contain deF
//The final activation key is abgHIjkLMNOPQRstuvwxyz
//
//Input	Output
//134softsf5ftuni2020rockz42
//Slice>>>3>>>7
//Contains>>>-rock
//Contains>>>-uni-
//Contains>>>-rocks
//Flip>>>Upper>>>2>>>8
//Flip>>>Lower>>>5>>>11
//Generate	
//
//Output
//134sf5ftuni2020rockz42
//Substring not found!
//Substring not found!
//Substring not found!
//134SF5FTuni2020rockz42
//134SF5ftuni2020rockz42
//Your activation key is: 134SF5ftuni2020rockz42
