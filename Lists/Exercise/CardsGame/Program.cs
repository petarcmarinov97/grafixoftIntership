using System;
using System.Linq;
using System.Collections.Generic;

namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerHand = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondPlayerHand = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sumFirst = firstPlayerHand.Sum();
            int sumSecond = secondPlayerHand.Sum();

            while (sumFirst > 0 && sumSecond > 0)
            {
                if (firstPlayerHand[0] == secondPlayerHand[0])
                {
                    firstPlayerHand.RemoveAt(0);
                    secondPlayerHand.RemoveAt(0);
                }
                else if (firstPlayerHand[0] > secondPlayerHand[0])
                {
                    int firstPlayerDeck = firstPlayerHand[0];
                    int secondPlayerDeck = secondPlayerHand[0];
                    firstPlayerHand.RemoveAt(0);
                    secondPlayerHand.RemoveAt(0);
                    firstPlayerHand.Add(firstPlayerDeck);
                    firstPlayerHand.Add(secondPlayerDeck);
                }
                else
                {
                    int secondPlayerDeck = secondPlayerHand[0];
                    int firstPlayerDeck = firstPlayerHand[0];
                    secondPlayerHand.RemoveAt(0);
                    firstPlayerHand.RemoveAt(0);
                    secondPlayerHand.Add(secondPlayerDeck);
                    secondPlayerHand.Add(firstPlayerDeck);
                }
                sumFirst = firstPlayerHand.Sum();
                sumSecond = secondPlayerHand.Sum();
            }

            if (sumFirst < sumSecond)
            {
                Console.WriteLine($"Second player wins! Sum: {sumSecond}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {sumFirst}");
            }
        }
    }
}
