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
                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "Remove":
                        list.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "RemoveAt":
                        list.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "Insert":
                        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "Contains":
                        if (list.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 1).ToArray()));
                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 0).ToArray()));
                        break;

                    case "GetSum":
                        Console.WriteLine(list.Sum());
                        break;

                    case "Filter":
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
                        break;
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

