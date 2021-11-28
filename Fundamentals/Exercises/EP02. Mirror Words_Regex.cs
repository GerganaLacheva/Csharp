using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace EP02._Mirror_Words_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\#{1}[A-z]{3,}\#{2}[A-z]{3,}\#{1}|\@{1}[A-z]{3,}\@{2}[A-z]{3,}\@{1}";

            MatchCollection matches = Regex.Matches(input,pattern);
            List<string> validWords = new List<string>();
            List<string> mirrorWords = new List<string>();


            foreach (Match match in matches)
            {
                validWords.Add(match.ToString());
            }

            for (int i = 0; i < validWords.Count; i++)
            {
                string currentInput = validWords[i];
                string firstWord = "";
                string secondWord = "";

                for (int j = 0; j < currentInput.Length / 2; j++)
                {
                    firstWord += currentInput[j];
                }

                for (int k = currentInput.Length - 1; k >= currentInput.Length / 2; k--)
                {
                    secondWord += currentInput[k];
                }

                if (firstWord == secondWord)
                {
                    mirrorWords.Add(currentInput);
                }

            }
            if (validWords.Count > 0)
            {
                Console.WriteLine($"{validWords.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            List<string> pairs = new List<string>();

            if (mirrorWords.Count > 0)
            {
                Console.WriteLine("The mirror words are:");

                foreach (var item in mirrorWords)
                {
                    var item1 = item.Substring(1, (item.Length / 2) - 2);
                    var item2 = item.Substring(item.Length / 2 + 1, (item.Length - ((item.Length / 2) + 2)));

                    string finalList = $"{item1} <=> {item2}";
                    pairs.Add(finalList);
                }

                Console.WriteLine($"{string.Join(", ", pairs)}");
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
//Problem 2 - Mirror words
//Problem for exam preparation for the Programming Fundamentals Course @SoftUni.
//Submit your solutions in the SoftUni judge system at https://judge.softuni.org/Contests/Practice/Index/2307#1.

//The SoftUni Spelling Bee competition is here. But it`s not like any other Spelling Bee competition out there. It`s different and a lot more fun! You, of course, are a participant, and you are eager to show the competition that you are the best, so go ahead, learn the rules and win!
//On the first line of the input, you will be given a text string. To win the competition, you have to find all hidden word pairs, read them, and mark the ones that are mirror images of each other.
//First of all, you have to extract the hidden word pairs. Hidden word pairs are:
//•	Surrounded by "@" or "#" (only one of the two) in the following pattern #wordOne##wordTwo# or @wordOne@@wordTwo@
//•	At least 3 characters long each (without the surrounding symbols)
//•	Made up of letters only
//If the second word, spelled backward, is the same as the first word and vice versa (casing matters!), they are a match, and you have to store them somewhere. Examples of mirror words: 
//#Part##traP# @leveL@@Level@ #sAw##wAs#
//•	If you don`t find any valid pairs, print: "No word pairs found!"
//•	If you find valid pairs print their count: "{valid pairs count} word pairs found!"
//•	If there are no mirror words, print: "No mirror words!"
//•	If there are mirror words print:
//"The mirror words are:
//{ wordOne} <=> { wordtwo}, { wordOne} <=> { wordtwo}, … { wordOne} <=> { wordtwo}
//"
//Input / Constraints
//•	You will recive a string.
//Output
//•	Print the proper output messages in the proper cases as described in the problem description.
//•	If there are pairs of mirror words, print them in the end, each pair separated by ", ".
//•	Each pair of mirror word must be printed with " <=> " between the words.
//
//Examples
//Input
//@mix#tix3dj#poOl##loOp#wl@@bong&song%4very$long@thong#Part##traP##@@leveL@@Level@##car#rac##tu@pack@@ckap@#rr#sAw##wAs#r#@w1r	
//
//Output	
//5 word pairs found!
//The mirror words are:
//Part <=> traP, leveL <=> Level, sAw <=> wAs
//
//Comments
//There are 5 green and yellow pairs that meet all requirements and thus are valid. 
//#poOl##loOp# is valid and looks very much like a mirror words pair, but it isn`t because the casings don`t match.
//#car#rac# "rac" spelled backward is "car", but this is not a valid pair because there is only one "#" between the words.
//@pack@@ckap@ is also valid, but "ckap" backward is "pakc" which is not the same as "pack", so they are not mirror words.
//
//Input
//#po0l##l0op# @bAc##cAB@ @LM@ML@ #xxxXxx##xxxXxx# @aba@@ababa@
//
//Output	
//2 word pairs found!
//No mirror words!	
//
//Comments
//"xxxXxx" backward is not the same as "xxxXxx"
//@aba@@ababa@ is a valid pair, but the word lengths are different - these are definitely not mirror words
//
//Input
//#lol#lol# @#God@@doG@# #abC@@Cba# @Xyu@#uyX#
//
//Output	
//No word pairs found!
//No mirror words!	
