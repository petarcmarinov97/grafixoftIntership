using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine()
                .Split(' ')
                .ToList();

            bool isChanged = false;

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    list.Add(int.Parse(command[1]));
                    isChanged = true;
                }
                if (command[0] == "Remove")
                {
                    list.Remove(int.Parse(command[1]));
                    isChanged = true;

                }
                if (command[0] == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(command[1]));
                    isChanged = true;

                }
                if (command[0] == "Insert")
                {
                    list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    isChanged = true;

                }
                if (command[0] == "Contains")
                {
                    if (list.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                if (command[0] == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 1).ToArray()));
                }
                if (command[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 0).ToArray()));
                }
                if (command[0] == "GetSum")
                {
                    Console.WriteLine(list.Sum());
                }
                if (command[0] == "Filter")
                {
                    if (command[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(x => x < int.Parse(command[2]))));
                    }
                    else if (command[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(x => x > int.Parse(command[2]))));
                    }
                    else if (command[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(x => x <= int.Parse(command[2]))));
                    }
                    else if (command[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(x => x >= int.Parse(command[2]))));
                    }
                }

                command = Console.ReadLine().Split(' ').ToList();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}

