using System;
using System.Linq;

namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Boolean flag = false;

            for (int i = 0; i < input.Length; i++)
            {
                //Calculate the sum from left to right
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }

                //Calculate the sum from right to left
                int rightSum = 0;
                for (int k = input.Length - 1; k > i; k--)
                {
                    rightSum += input[k];
                }

                //Checking for equal sums and if there have a coincidence flag = true
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    flag = true;
                }
            }

            //Checking if flag = false printing "no"
            if(flag == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
