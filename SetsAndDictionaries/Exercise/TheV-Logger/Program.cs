using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    internal class Program
    {
        public static string input;
        public static Dictionary<string, Dictionary<string, HashSet<string>>> dataBase = new Dictionary<string, Dictionary<string, HashSet<string>>>();
        public static string[] commands;
        public static string vlogger;
        public static string currentCommand;
        public static string secondVloger;
        static void Main(string[] args)
        {
            while ((input = Console.ReadLine()) != "Statistics")
            {
                ReadInput();
                if (currentCommand == "joined")
                {
                    AddVlogerIntoDataBase();
                }
                else if (currentCommand == "followed")
                {
                    FollowVloger();
                }
            }

            PrintStatistics();
        }

        static void ReadInput()
        {
            commands = input.Split(' ').ToArray();
            vlogger = commands[0];
            currentCommand = commands[1];
        }
        static void AddVlogerIntoDataBase()
        {
            if (!dataBase.ContainsKey(vlogger))
            {
                dataBase.Add(vlogger, new Dictionary<string, HashSet<string>>());
                dataBase[vlogger].Add("followers", new HashSet<string>());
                dataBase[vlogger].Add("following", new HashSet<string>());
            }
        }
        static void FollowVloger()
        {
            secondVloger = commands[2];

            if (vlogger != secondVloger && dataBase.ContainsKey(vlogger) && dataBase.ContainsKey(secondVloger))
            {
                dataBase[vlogger]["following"].Add(secondVloger);
                dataBase[secondVloger]["followers"].Add(vlogger);
            }
        }
        static void PrintStatistics()
        {
            Console.WriteLine($"The V-Logger has a total of {dataBase.Keys.Count} vloggers in its logs.");

            int position = 1;
            var dataBaseDescending = dataBase.OrderByDescending(x => x.Value["followers"].Count()).ThenBy(x => x.Value["following"].Count());
            
            foreach (var vlogger in dataBaseDescending)
            {
                Console.WriteLine($"{position}. {vlogger.Key} : {vlogger.Value["followers"].Count()} followers, {vlogger.Value["following"].Count()} following");

                if (position == 1)
                {
                    foreach (var follower in vlogger.Value["followers"].OrderBy(f => f))
                        Console.WriteLine($"*  {follower}");
                }

                position++;
            }
        }
    }
}
