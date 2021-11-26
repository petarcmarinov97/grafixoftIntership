using System;
using System.Linq;

namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isLeftEqualsToRight = false;

            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }

                int rightSum = 0;
                for (int k = input.Length - 1; k > i; k--)
                {
                    rightSum += input[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isLeftEqualsToRight = true;
                }
            }

            if (!isLeftEqualsToRight)
            {
                Console.WriteLine("no");
            }
        }
    }
}
