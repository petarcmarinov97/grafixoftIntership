using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] data = command.Split(':');

                if (data[0] == "Add")
                {
                    string title = data[1];

                    if (!list.Contains(title))
                    {
                        list.Add(title);
                    }
                }
                else if (data[0] == "Insert")
                {
                    string title = data[1];
                    int index = int.Parse(data[2]);

                    if (!list.Contains(title))
                    {
                        if (index >= 0 && index < list.Count)
                        {
                            list.Insert(index, title);
                        }
                    }
                }
                else if (data[0] == "Remove")
                {
                    string title = data[1];

                    if (list.Contains(title))
                    {
                        list.Remove(title);
                    }
                }
                else if (data[0] == "Swap")
                {
                    string firstTitle = data[1];
                    string secondTitle = data[2];

                    if (list.Contains(firstTitle) && list.Contains(secondTitle))
                    {
                        int firstTitleIndex = list.IndexOf(firstTitle);
                        int secondTitleIndex = list.IndexOf(secondTitle);

                        list[firstTitleIndex] = secondTitle;
                        list[secondTitleIndex] = firstTitle;


                        if (firstTitleIndex + 1 < list.Count && secondTitleIndex + 1 < list.Count)
                        {
                            if (list[firstTitleIndex + 1] == $"{firstTitle}-Exercise" && list[secondTitleIndex + 1] == $"{secondTitle}-Exercise")
                            {
                                string current = list[secondTitleIndex + 1];
                                list[secondTitleIndex + 1] = list[firstTitleIndex + 1];
                                list[firstTitleIndex + 1] = current;
                            }
                            else if (list[firstTitleIndex + 1] == $"{firstTitle}-Exercise")
                            {
                                list.Insert(secondTitleIndex + 1, list[firstTitleIndex + 1]);

                                if (secondTitleIndex > firstTitleIndex)
                                {
                                    list.RemoveAt(firstTitleIndex + 1);
                                }
                                else if (secondTitleIndex < firstTitleIndex)
                                {
                                    list.RemoveAt(firstTitleIndex + 2);
                                }

                            }
                            else if (list[secondTitleIndex + 1] == $"{secondTitle}-Exercise")
                            {
                                list.Insert(firstTitleIndex + 1, list[secondTitleIndex + 1]);

                                if (firstTitleIndex < secondTitleIndex)
                                {
                                    list.RemoveAt(secondTitleIndex + 2);
                                }
                                else if (firstTitleIndex > secondTitleIndex)
                                {
                                    list.RemoveAt(secondTitleIndex + 1);
                                }
                            }
                        }
                        else if (firstTitleIndex + 1 < list.Count)
                        {
                            if (list[firstTitleIndex + 1] == $"{firstTitle}-Exercise")
                            {
                                list.Insert(secondTitleIndex + 1, list[firstTitleIndex + 1]);

                                if (secondTitleIndex > firstTitleIndex)
                                {
                                    list.RemoveAt(firstTitleIndex + 1);
                                }
                                else if (secondTitleIndex < firstTitleIndex)
                                {
                                    list.RemoveAt(firstTitleIndex + 2);
                                }
                            }
                        }
                        else if (secondTitleIndex + 1 < list.Count)
                        {
                            if (list[secondTitleIndex + 1] == $"{secondTitle}-Exercise")
                            {
                                list.Insert(firstTitleIndex + 1, list[secondTitleIndex + 1]);

                                if (firstTitleIndex < secondTitleIndex)
                                {
                                    list.RemoveAt(secondTitleIndex + 2);
                                }
                                else if (firstTitleIndex > secondTitleIndex)
                                {
                                    list.RemoveAt(secondTitleIndex + 1);
                                }
                            }
                        }
                    }
                }
                else if (data[0] == "Exercise")
                {
                    string title = data[1];

                    if (list.Contains(title))
                    {
                        int indexTitle = list.IndexOf(title);

                        if (indexTitle + 1 < list.Count)
                        {
                            if (list[indexTitle + 1] != $"{title}-Exercise")
                            {
                                list.Insert(indexTitle + 1, $"{title}-Exercise");
                            }
                        }
                        else
                        {
                            list.Add($"{title}-Exercise");
                        }
                    }
                    else
                    {
                        list.Add(title);
                        list.Add($"{title}-Exercise");
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
