using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(" ")
                .ToList();

            List<string> command = Console.ReadLine()
                .Split(' ')
                .ToList();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    list.Add(command[1]);
                }
                else if (command[0] == "Remove")
                {
                    list.Remove(command[1]);

                }
                else if (command[0] == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    list.Insert(int.Parse(command[2]), command[1]);
                }

                command = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
