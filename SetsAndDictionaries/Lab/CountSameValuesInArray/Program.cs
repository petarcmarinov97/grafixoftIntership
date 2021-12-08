using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSameValuesInArray
{
    internal class Program
    {
        public static Dictionary<string, int> dictonary = new Dictionary<string, int>();
        public static string key;
        public static string[] input;
        static void Main(string[] args)
        {
            input = Console.ReadLine().Split().ToArray();

            CountNumberOccurences();
            PrintDictionary();
        }

        public static void CountNumberOccurences()
        {
            for (int i = 0; i < input.Length; i++)
            {
                key = input[i];
                CheckForContaining();
            }
        }
        public static void CheckForContaining()
        {
            if (!dictonary.ContainsKey(key))
            {
                dictonary.Add(key, 1);
            }
            else
            {
                dictonary[key]++;
            }
        }
        public static void PrintDictionary()
        {
            Console.WriteLine(string.Join('\n', dictonary.Select(x => $"{x.Key} - {x.Value} times")));
        }
    }
}
