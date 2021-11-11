using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07.String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int explosion = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (explosion > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1); // премахваме позицията на този индекс
                    explosion--; // един експлозив е използван
                    i--; // след Remove() позициите се изместват с една на ляво,
                         // затова връщаме i с един индекс назад, за да почне итерацията отново от правилния индекс  
                }
                else if (input[i] == '>')
                {
                    explosion += int.Parse(input[i + 1].ToString()); // достъпваме позицията след '>' и добавяме остатъка от експлозия(ако има)
                }
            }
            Console.WriteLine(input);
        }
    }
}
//7.String Explosion
//Explosions are marked with '>'. Immediately after the mark, there will be an integer, which signifies the strength of the explosion.
//You should remove x characters (where x is the strength of the explosion), starting after the punch character ('>').
//If you find another explosion mark ('>') while you’re deleting characters, you should add the strength to your previous explosion.
//When all characters are processed, print the string without the deleted characters. 
//You should not delete the explosion character – '>', but you should delete the integers, which represent the strength. 
//Input
//You will receive single line with the string.
//Output
//Print what is left from the string after explosions.
//Constraints
//•	You will always receive a strength for the punches
//•	The path will consist only of letters from the Latin alphabet, integers and the char '>'
//•	The strength of the punches will be in the interval [0…9]
//Examples
//Input		
//abv>1>1>2>2asdasd	

//Output
//abv>>>>dasd	

//Comments
//1st explosion is at index 3 and it is with strength of 1. We delete only the digit after the explosion character. The string will look like this: abv >> 1 > 2 > 2asdasd
//2nd explosion is with strength one and the string transforms to this: abv >>> 2 > 2asdasd
//3rd explosion is now with strength of 2. We delete the digit and we find another explosion. At this point the string looks like this: abv >>>> 2asdasd.
//4th explosion is with strength 2. We have 1 strength left from the previous explosion, we add the strength of the current explosion to what is left and that adds up to a total strength of 3. We delete the next three characters and we receive the string abv>>>>dasd 
//We do not have any more explosions and we print the result: abv >>>> dasd

//Input
//peter > 2sis > 1a > 2akarate > 4hexmaster 

//Output
//peter>is>a>karate>master	
