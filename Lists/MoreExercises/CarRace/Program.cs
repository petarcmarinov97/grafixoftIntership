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

            for (int i = 0; i < inputList.Count / 2; i++)
            {
                sumLeftPlayer = inputList[i] != 0 ? sumLeftPlayer + inputList[i] : sumLeftPlayer * 0.8;
                sumRightPlayer = inputList[inputList.Count-1-i] != 0 ? sumRightPlayer + inputList[inputList.Count - 1 - i] : sumRightPlayer * 0.8;
            }

            string name = sumLeftPlayer < sumRightPlayer ? "left" : "right";
            double sumPlayer = sumLeftPlayer < sumRightPlayer ? sumLeftPlayer : sumRightPlayer;
            Console.WriteLine($"The winner is {name} with total time: {sumPlayer}");
        }
    }
}
