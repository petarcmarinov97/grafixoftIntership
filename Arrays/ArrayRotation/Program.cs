using System;
using System.Linq;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i < rotations; i++)
            {
                
                int first = input[0];

                for(int j = 0 ; j < input.Length-1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Length-1] = first;
            }

            for(int i=0; i < input.Length; i++)
            { 
                Console.Write(input[i] + " ");
            }
        }
    }
}
