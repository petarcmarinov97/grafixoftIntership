using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    internal class Program
    {
        public static int number;
        public static Dictionary<string, Dictionary<string, int>> dataBase = new Dictionary<string, Dictionary<string, int>>();
        public static string[] delivery;
        public static string[] searchInput;
        public static string color;
        public static string currentCloathing;
        public static string colorToSearch;
        public static string cloathingToSearch;
        static void Main(string[] args)
        {
            number = int.Parse(Console.ReadLine());
            ReceiveClothes();
            SearchCloathes();
            PrintWardrobeClothes();
        }
        static void ReceiveClothes()
        {
            for (int i = 0; i < number; i++)
            {
                delivery = Console.ReadLine()
                    .Split(new string[] { " -> ", "," },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                color = delivery[0];
                for (int j = 1; j < delivery.Length; j++)
                {
                    currentCloathing = delivery[j];
                    ChecksTheWardrobe();
                }
            }
        }
        static void ChecksTheWardrobe()
        {
            if (!dataBase.ContainsKey(color))
            {
                dataBase.Add(color, new Dictionary<string, int>());

                if (!dataBase[color].ContainsKey(currentCloathing))
                {
                    dataBase[color].Add(currentCloathing, 1);
                }
                else
                {
                    dataBase[color][currentCloathing]++;
                }
            }
            else
            {
                if (!dataBase[color].ContainsKey(currentCloathing))
                {
                    dataBase[color].Add(currentCloathing, 1);
                }
                else
                {
                    dataBase[color][currentCloathing]++;
                }
            }
        }
        static void SearchCloathes()
        {
            searchInput = Console.ReadLine().Split(" ").ToArray();
            colorToSearch = searchInput[0];
            cloathingToSearch = searchInput[1];
        }
        static void PrintWardrobeClothes()
        {
            foreach (var kvp in dataBase)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var (cloathing, count) in kvp.Value)
                {
                    if (kvp.Key == colorToSearch && cloathing == cloathingToSearch)
                    {
                        Console.WriteLine($"* {cloathing} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloathing} - {count}");
                    }
                }
            }
        }
    }
}
