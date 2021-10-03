using System;
using System.Linq;

namespace WP
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNA = int.Parse(Console.ReadLine());

            int[] bestDNA = new int[DNA];
            int leftmostIndex = DNA;
            int bestDNALenght = 0;
            int bestDNASum = 0;
            int bestDNANumber = 1;

            string input = Console.ReadLine();
            int temporaryDNA = 0;

            while (input != "Clone them!")
            {
                int[] temporaryDNAInput = input.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                temporaryDNA++;

                int temporaryDNALenght = 0;
                int previousDNALenght = 0;
                int temporaryLongestDNA = 0;

                int leftmostIndexIntemporaryArray = DNA;

                int temporaryDNASum = 0;

                for (int i = 0; i < temporaryDNAInput.Length; i++)
                {
                    if (temporaryDNAInput[i] == 1)
                    {
                        temporaryDNALenght++;
                        temporaryDNASum++;
                    }
                    else
                    {
                        previousDNALenght = temporaryDNALenght;
                        temporaryDNALenght = 0;
                    }

                    if (temporaryDNALenght > previousDNALenght)
                    {
                        temporaryLongestDNA = temporaryDNALenght;
                        leftmostIndexIntemporaryArray = i - temporaryDNALenght + 1;
                    }
                }

                if (temporaryLongestDNA > bestDNALenght)
                {
                    bestDNALenght = temporaryLongestDNA;
                    leftmostIndex = leftmostIndexIntemporaryArray;
                    bestDNA = temporaryDNAInput;
                    bestDNANumber = temporaryDNA;
                    bestDNASum = temporaryDNASum;
                }
                else if (temporaryLongestDNA == bestDNALenght)
                {
                    if (leftmostIndexIntemporaryArray < leftmostIndex)
                    {
                        leftmostIndex = leftmostIndexIntemporaryArray;
                        bestDNASum = temporaryDNASum;
                        bestDNA = temporaryDNAInput;
                        bestDNANumber = temporaryDNA;
                    }
                    else if (leftmostIndex == leftmostIndexIntemporaryArray)
                    {
                        if (temporaryDNASum > bestDNASum)
                        {
                            bestDNASum = temporaryDNASum;
                            bestDNA = temporaryDNAInput;
                            bestDNANumber = temporaryDNA;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestDNANumber} with sum: {bestDNASum}.");
            Console.WriteLine(string.Join(" ", bestDNA));

        }
    }
}
//Kamino Factory
//The clone factory in Kamino got another order to clone troops. But this time you are tasked to find the best DNA sequence to use in the production. 
//You will receive the DNA length and until you receive the command "Clone them!" you will be receiving a DNA sequences of ones and zeroes, split by "!" (one or several).
//You should select the sequence with the longest subsequence of ones. If there are several sequences with same length of subsequence of ones, print the one with the leftmost starting index, if there are several sequences with same length and starting index, select the sequence with the greater sum of its elements.
//After you receive the last command "Clone them!" you should print the collected information in the following format:
//"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
//"{DNA sequence, joined by space}"
//Input / Constraints
//•	The first line holds the length of the sequences – integer in range [1…100];
//•	On the next lines until you receive "Clone them!" you will be receiving sequences (at least one) of ones and zeroes, split by "!" (one or several).
// Output
//The output should be printed on the console and consists of two lines in the following format:
//"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
//"{DNA sequence, joined by space}"
// Examples
//Input	            Output	                                    
//5                 Best DNA sample 2 with sum: 2.              
//1!0!1!1!0         0 1 1 0 0
//0!1!1!0!0
//Clone them!	
//   
//Comments
//We receive 2 sequences with same length of subsequence of ones, but the second is printed, because its subsequence starts at index[1].
//
//Input             Output	                            
//4                 Clone them!	Best DNA sample 1 with sum: 3.
//1!1!0!1           1 1 0 1
//1!0!0!1
//1!1!0!0                                               
//
// Comments
//We receive 3 sequences. Both 1 and 3 have same length of subsequence of ones -> 2, and both start from index[0], but the first is printed, because its sum is greater.
