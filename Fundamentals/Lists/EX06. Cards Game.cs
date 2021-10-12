using System;
using System.Linq;
using System.Collections.Generic;

namespace EX06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            while (true)
            {
                if (player1[0] > player2[0])
                {
                    player1.Add(player1[0]);
                    player1.Add(player2[0]);
                }
                else if (player1[0] < player2[0])
                {
                    player2.Add(player2[0]);
                    player2.Add(player1[0]);
                }

                player1.Remove(player1[0]);
                player2.Remove(player2[0]);

                if (player1.Count == 0)
                {
                    int sum = player2.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (player2.Count == 0)
                {
                    int sum = player1.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
//6.Cards Game
//You will be given two hands of cards, which will be represented by integers. Assume each one is held by a different player. You have to find which one has the winning deck. You start from the beginning of both hands of cards. Compare the cards from the first deck to the cards from the second deck. The player, who holds the more powerful card on the current iteration, takes both cards and puts them at the back of his hand - the second player's card is placed last, and the first person's card (the winning one) comes after it (second to last). If both players' cards have the same values - no one wins, and the two cards must be removed from both hands.  The game is over when only one of the decks is left without any cards. You have to display the result on the console and the sum of the remaining cards: "{First/Second} player wins! Sum: {sum}".
//Examples
//Input	Output
//20 30 40 50
//10 20 30 40	First player wins! Sum: 240
//10 20 30 40 50
//50 40 30 30 10  Second player wins! Sum: 50
