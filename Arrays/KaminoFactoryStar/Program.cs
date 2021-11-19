using System;
using System.Linq;

namespace KaminoFactoryStar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sequenceLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] dna = new int[sequenceLength];
            int length = 0;
            int index = 0;
            int sum = 0;
            int row = 0;
            int currentRow = 0;

            while (input != "Clone them!")
            {

                int[] currentDna = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                currentRow++;

                int currentSum = currentDna.Sum();

                int currentLength = 0;
                int currentIndex = 0;

                for (int i = 0; i < currentDna.Length; i++)
                {
                    if (currentDna[i] == 1)
                    {
                        currentLength++;

                        if (currentLength == 1)
                        {
                            currentIndex = i;
                        }

                        if (currentLength > length || currentLength == length && (currentIndex < index || currentSum > sum))
                        {
                            length = currentLength;
                            index = currentIndex;
                            row = currentRow;

                            dna = currentDna;
                            sum = currentSum;
                        }
                    }
                    else
                    {
                        currentIndex = 0;
                        currentLength = 0;
                    }
                }

                input = Console.ReadLine();
            }

            if (row == 0)
            {
                row = 1;
            }

            Console.WriteLine($"Best DNA sample {row} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", dna));
        }
    }
}