using System;
using System.Collections.Generic;
using System.Linq;

namespace EX08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();           

            while (true)
            {
            string command = Console.ReadLine();                                
                if (command=="3:1")
                {
                    break;
                }

                string[] parts = command.Split();                               //разделяме командата на три части
                string action = parts[0];

                if (action == "merge")
                {                                                               //проверяваме дали е в обхвата на листа
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);


                    if (startIndex >= names.Count || endIndex < 0)              //това се двата невалидни случая - ако startIndex < 0 и/или endIndex < 0
                    {
                        continue;
                    }
                    if (startIndex < 0)                                         //ако startIndex < 0 го сетваме на първи елемент                                    
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= names.Count)                                //ако endIndex >листа -> сетваме го за последен елемент
                    {
                        endIndex = names.Count - 1;
                    }

                    string mergedString = string.Empty;                         //създаваме една временна променлива, която да съдържа обединените стрингове

                    for (int i = startIndex; i <= endIndex; i++)                //обхождаме само елементите между зададените от входа startInedex и endIndex
                    {
                        string name = names[i];                                 //взимаме текущия елемент за всяка итерация
                        mergedString += name;                                   //на всяка итерация долепяме текущия елемент в новия mergedString
                    }

                    names.RemoveRange(startIndex, endIndex - startIndex + 1);   //от startIndex премахваме елементите, които са били първоначално в списъка преди да ги конкатенираме
                    names.Insert(startIndex, mergedString);                     //на startIndex присвояваме mergedString, за да формираме новия лист
                }


                else if (action == "divide")
                {
                    int index = int.Parse(parts[1]);
                    int partitions = int.Parse(parts[2]);

                    string element = names[index];
                    names.RemoveAt(index);

                    int partitionSize = element.Length / partitions;

                    List<string> substrings = new List<string>();

                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string substring = element.Substring(i * partitionSize, partitionSize);
                        substrings.Add(substring);
                    }

                    string lastSubstring = element.Substring((partitions - 1) * partitionSize);
                    substrings.Add(lastSubstring);

                    names.InsertRange(index, substrings);
                }
            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
//Anonymous Threat
//Anonymous has created a cyber hyper virus, which steals data from the the CIA. You, as the lead security developer in CIA, have been tasked to analyze the software of the virus and observe its actions on the data. The virus is known for its innovative and unbelievably clever technique of merging and dividing data into partitions. 
//You will receive a single input line, containing strings, separated by spaces. The strings may contain any ASCII character except whitespace.Then you will begin receiving commands in one of the following formats:
//•	merge
//{ startIndex}
//{ endIndex}
//•	divide
//{ index}
//{ partitions}
//Every time you receive the merge command, you must merge all elements from the startIndex, to the endIndex. In other words, you should concatenate them. 
//Example: { abc, def, ghi} -> merge 0 1-> { abcdef, ghi}
//If any of the given indexes is out of the array, you must take only the range that is inside the array and merge it.
//Every time you receive the divide command, you must divide the element at the given index, into several small substrings with equal length. The count of the substrings should be equal to the given partitions. 
//Example: { abcdef, ghi, jkl} -> divide 0 3-> { ab, cd, ef, ghi, jkl}
//If the string cannot be exactly divided into the given partitions, make all partitions except the last with equal lengths, and make the last one – the longest. 
//Example: { abcd, efgh, ijkl} -> divide 0 3-> { a, b, cd, efgh, ijkl}
//The input ends when you receive the command "3:1". At that point, you must print the resulting elements, joined by a space.
//Input
//•	The first input line will contain the array of data.
//•	On the next several input lines you will receive commands in the format specified above.
//•	The input ends when you receive the command "3:1".
//Output
//•	As output you must print a single line containing the elements of the array, joined by a space.
//Constrains
//•	The strings in the array may contain any ASCII character except whitespace.
//•	The startIndex and the endIndex will be in range [-1000, 1000].
//•	The endIndex will always be greater than the startIndex.
//•	The index in the divide command will always be inside the array.
//•	The partitions will be in range [0, 100].
//•	Allowed working time/memory: 100ms / 16MB.
//Examples

//Input	
//Ivo Johny Tony Bony Mony
//merge 0 3
//merge 3 4
//merge 0 3
//3:1

//Output
//IvoJohnyTonyBonyMony

//Input
//abcd efgh ijkl mnop qrst uvwx yz
//merge 4 10
//divide 4 5
//3:1


//Output
//abcd efgh ijkl mnop qr st uv wx yz
