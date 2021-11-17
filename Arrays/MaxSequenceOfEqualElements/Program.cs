using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int maxCounter = 0;
            int sequenceNumber = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        sequenceNumber = input[i];
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            if (maxCounter > 0)
            {
                for (int i = 0; i <= maxCounter; i++)
                {
                    Console.Write(sequenceNumber + " ");
                }
            }
        }
    }
}
