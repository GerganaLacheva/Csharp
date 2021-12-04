using System;
using System.Linq;

namespace EP_01._Secret_Chat_TextProc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] tokens = command.Split(":|:");
                string action = tokens[0];

                if (action == "InsertSpace")
                {
                    int index = int.Parse(tokens[1]);
                    message = message.Insert(index, " ");
                }
                else if (action == "Reverse")
                {
                    string substring = tokens[1];
                    if (message.Contains(substring))
                    {
                        int index = message.IndexOf(substring);
                        message = message.Remove(index, substring.Length);
                        message = message + string.Join("", substring.Reverse());
                    }
                    else
                    {
                        Console.WriteLine("error");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = tokens[1];
                    string replacement = tokens[2];
                    message = message.Replace(substring, replacement);
                }

                Console.WriteLine(message);

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
Problem 1 - Secret Chat
//Problem for exam preparation for the Programming Fundamentals Course @SoftUni.
//Submit your solutions in the SoftUni judge system at https://judge.softuni.org/Contests/Practice/Index/2307#0.

//You have plenty of free time, so you decide to write a program that conceals and reveals your received messages. Go ahead and type it in!
//On the first line of the input, you will receive the concealed message. After that, until the "Reveal" command is given, you will receive strings with instructions for different operations that need to be performed upon the concealed message to interpret it and reveal its actual content. There are several types of instructions, split by ":|:"
//•	"InsertSpace:|:{index}":
//o Inserts a single space at the given index. The given index will always be valid.
//•	"Reverse:|:{substring}":
//o If the message contains the given substring, cut it out, reverse it and add it at the end of the message. 
//o	If not, print "error".
//o	This operation should replace only the first occurrence of the given substring if there are two or more occurrences.
//•	"ChangeAll:|:{substring}:|:{replacement}":
//o Changes all occurrences of the given substring with the replacement text.
//Input / Constraints
//•	On the first line, you will receive a string with a message.
//•	On the following lines, you will be receiving commands, split by ":|:".
//Output
//•	After each set of instructions, print the resulting string. 
//•	After the "Reveal" command is received, print this message:
//"You have a new text message: {message}"
//
//Examples
//Input	
//heVVodar!gniV
//ChangeAll:|:V:|:l
//Reverse:|:!gnil
//InsertSpace:|:5
//Reveal
//
//Output
//hellodar!gnil
//hellodarling!
//hello darling!
//You have a new text message: hello darling!
//
//Comments
//ChangeAll:|:V:|:l
//heVVodar!gniV -> hellodar!gnil (We replace all occurrences of "V" with "l")
//Reverse:|:!gnil
//hellodar!gnil-> !gnil->ling!->hellodarling!(We reverse!gnil to ling! And put it at the end of the string)
//InsertSpace:|:5
//hellodarling!->hello.darling!(We insert a space at index 5)
//Finally, after receiving the "Reveal" command, we print the resulting message.
//
//Input	
//Hiware?uiy
//ChangeAll:|:i:|:o
//Reverse:|:? uoy
//Reverse:|:jd
//InsertSpace:|:3
//InsertSpace:|:7
//Reveal
//
//Output
//Howare?uoy
//Howareyou?
//error
//How areyou?
//How are you?
//You have a new text message: How are you?
