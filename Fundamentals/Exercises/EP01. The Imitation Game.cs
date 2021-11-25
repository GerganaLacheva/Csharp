using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP01.The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder(input);
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] splittedCommands = command.Split('|');

                if (splittedCommands[0] == "ChangeAll")
                {
                    result.Replace(splittedCommands[1], splittedCommands[2]);
                }
                else if (splittedCommands[0] == "Insert")
                {
                    int index = int.Parse(splittedCommands[1]);
                    string value = splittedCommands[2];
                    result.Insert(index, value);
                }
                else if (splittedCommands[0] == "Move")
                {
                    int number = int.Parse(splittedCommands[1]);
                    string substring = result.ToString().Substring(0, number);
                    result.Remove(0, number);
                    result.Append(substring);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {result}");
        }
    }
}
//Problem 1 - The Imitation Game
//Problem for exam preparation for the Programming Fundamentals Course @SoftUni.
//Submit your solutions in the SoftUni judge system at https://judge.softuni.org/Contests/Practice/Index/2525#0.

//During World War 2, you are a mathematician who has joined the cryptography team to decipher the enemy's enigma code. Your job is to create a program to crack the codes. 
//On the first line of the input, you will receive the encrypted message. After that, until the "Decode" command is given, you will be receiving strings with instructions for different operations that need to be performed upon the concealed message to interpret it and reveal its true content. There are several types of instructions, split by '|'
//•	"Move {number of letters}":
//o Moves the first n letters to the back of the string
//•	"Insert {index} {value}":
//o Inserts the given value before the given index in the string
//•	"ChangeAll {substring} {replacement}":
//o Changes all occurrences of the given substring with the replacement text
//Input / Constraints
//•	On the first line, you will receive a string with a message.
//•	On the following lines, you will be receiving commands, split by '|' .
//Output
//•	After the "Decode" command is received, print this message:
//"The decrypted message is: {message}"
//Examples
//Input	                        Output
//zzHe
//ChangeAll|z|l
//Insert|2|o
//Move|3
//Decode	                    The decrypted message is: Hello
//Input                         Output
//owyouh
//Move|2
//Move|3
//Insert|3|are
//Insert|9|?
//Decode	                   The decrypted message is: howareyou ?

