using System;
using System.Linq;
using System.Collections.Generic;

namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> path = Console.ReadLine().Split('\\').ToList();

            string nameWeNeed = path[path.Count - 1];
            List<string> result = nameWeNeed.Split('.').ToList();

            Console.WriteLine($"File name: {result[0]}");
            Console.WriteLine($"File extension: {result[1]}");

        }

    }
}
