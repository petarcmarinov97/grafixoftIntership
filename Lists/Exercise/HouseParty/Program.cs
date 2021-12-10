using System;
using System.Linq;
using System.Collections.Generic;

namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> outputList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> currCommands = Console.ReadLine().Split(' ').ToList();
                string currName = currCommands[0];

                if (outputList.Contains(currName) && currCommands[2] != "not")
                {
                    Console.WriteLine(currName + " is already in the list!");
                }

                if (currCommands[2] != "not" && !outputList.Contains(currName))
                {
                    outputList.Add(currName);
                }

                if (currCommands[2] == "not" && !outputList.Contains(currName))
                {
                    Console.WriteLine(currName + " is not in the list!");
                }

                if (outputList.Contains(currName) && currCommands[2] == "not")
                {
                    while (outputList.Contains(currName))
                    {
                        outputList.Remove(currName);
                    }
                }
            }

            Console.WriteLine(string.Join("\n", outputList));
        }
    }
}
