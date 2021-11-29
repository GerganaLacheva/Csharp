using System;

namespace EP01._The_Imitation_Game_TextProc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] commandArguments = command.Split("|");


                switch (commandArguments[0])
                {
                    case "Move":

                        int lettersCount = int.Parse(commandArguments[1]);
                        string chars = message.Substring(0, lettersCount);
                        message = message.Substring(lettersCount) + chars;
                        break;
                    case "Insert":
                        int index = int.Parse(commandArguments[1]);
                        message = message.Insert(index,commandArguments[2]);
                        break;
                    case "ChangeAll":
                        while (message.Contains(commandArguments[1]))
                        {
                            message = message.Replace(commandArguments[1],commandArguments[2]);
                        }
                        break;

                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
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
//
//Examples
//Input	
//zzHe
//ChangeAll|z|l
//Insert|2|o
//Move|3
//Decode	
//
//Output
//The decrypted message is: Hello
//
//Comments
//ChangeAll|z|l
//zzHe → llHe (We replace all occurrences of 'z' with 'l')
//Insert | 2 | o
//llHe → lloHe(We add an 'o' before the character on index 2)
//Move | 3
//lloHe → Hello(We take the first three characters and move them to the end of the string)
//Finally, after receiving the "Decode" command, we print the resulting message.
//
//Input	
//owyouh
//Move|2
//Move|3
//Insert|3|are
//Insert|9|?
//Decode	
//
//Output
//The decrypted message is: howareyou ?
