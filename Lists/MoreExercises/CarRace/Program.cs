using System;
using System.Linq;
using System.Collections.Generic;

namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            double sumLeftPlayer = 0;
            double sumRightPlayer = 0;

            // Left player
            for (int i = 0; i < inputList.Count / 2; i++)
            {
                if (inputList[i] != 0)
                {
                    sumLeftPlayer += inputList[i];
                }
                else
                {
                    sumLeftPlayer = sumLeftPlayer * 0.8;
                }
            }

            // Right player
            for (int i = inputList.Count - 1; i > inputList.Count / 2; i--)
            {
                if (inputList[i] != 0)
                {
                    sumRightPlayer += inputList[i];
                }
                else
                {
                    sumRightPlayer = sumRightPlayer * 0.8;
                }
            }

            if (sumLeftPlayer < sumRightPlayer)
            {
                Console.WriteLine($"The winner is left with total time: {sumLeftPlayer}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumRightPlayer}");
            }
        }
    }
}
