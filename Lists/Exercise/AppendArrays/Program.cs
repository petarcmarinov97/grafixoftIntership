using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            List<int> output = new List<int>();

            foreach (var str in list)
            {
                output.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
