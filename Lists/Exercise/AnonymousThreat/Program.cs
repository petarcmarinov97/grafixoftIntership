using System;
using System.Linq;
using System.Collections.Generic;

namespace AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();

            string str = Console.ReadLine();
            while (str != "3:1")
            {
                List<string> command = str.Split(' ').ToList();
                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);
                string newElement = string.Empty;

                if (endIndex >= list.Count || endIndex < 0)
                {
                    endIndex = list.Count - 1;
                }
                if (startIndex < 0 || startIndex >= list.Count)
                {
                    startIndex = 0;
                }

                if (command[0] == "merge")
                {

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        newElement += list[i];
                    }

                    list.RemoveRange(startIndex, endIndex - startIndex + 1);
                    list.Insert(startIndex, newElement);
                }
                if (command[0] == "divide")
                {
                    List<string> divided = new List<string>();
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    string word = list[index];
                    list.RemoveAt(index);
                    int parts = word.Length / partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            divided.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            divided.Add(word.Substring(i * parts, parts));

                        }
                    }

                    list.InsertRange(index, divided);
                }

                str = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}

