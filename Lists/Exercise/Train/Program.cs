using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine()
                .Split(' ')
                .ToList();

            int currentPeople = 0;

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    list.Add(int.Parse(command[1]));
                }
                else
                {
                    int counter = 0;
                    int peopleToBeAdded = int.Parse(command[0]);

                    foreach (var number in list)
                    {
                        if (list[counter] + peopleToBeAdded <= maxCapacity)
                        {
                            currentPeople = list[counter];
                            list.RemoveAt(counter);
                            list.Insert(counter, currentPeople + peopleToBeAdded);
                            break;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }

                command = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
