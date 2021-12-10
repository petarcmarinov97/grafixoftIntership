using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                List<string> commandList = command.Split(' ').ToList();

                if (commandList[0] == "Add")
                {
                    numbersList.Add(int.Parse(commandList[1]));
                }
                else if (commandList[0] == "Insert")
                {
                    int number = int.Parse(commandList[1]);
                    int index = int.Parse(commandList[2]);

                    if (number < numbersList.Count && index >= 0)
                    {
                        numbersList.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commandList[0] == "Remove")
                {
                    int index = int.Parse(commandList[1]);

                    if (index >= numbersList.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbersList.RemoveAt(index);
                    }
                }
                else if (commandList[0] == "Shift" && commandList[1] == "left")
                {
                    for (int i = 0; i < int.Parse(commandList[2]); i++)
                    {
                        int firstNum = numbersList[0];
                        numbersList.Remove(numbersList[0]);
                        numbersList.Add(firstNum);
                    }
                }
                else if (commandList[0] == "Shift" && commandList[1] == "right")
                {
                    for (int i = 0; i < int.Parse(commandList[2]); i++)
                    {
                        int lastNum = numbersList[numbersList.Count - 1];
                        numbersList.RemoveAt(numbersList.Count - 1);
                        numbersList.Insert(0, lastNum);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
