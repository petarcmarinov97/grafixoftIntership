using System;
using System.Linq;

namespace LadyBugsStar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());
            int[] bugsSize = new int[sizeField];
            int[] startPositions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var index in startPositions)
            {
                if (index >= 0 && index < bugsSize.Length)
                {
                    bugsSize[index] = 1;
                }
            }

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                int startIndex = int.Parse(command.Split()[0]);
                int step = int.Parse(command.Split()[2]);
                string direction = command.Split()[1];

                if (startIndex >= 0 && startIndex < bugsSize.Length)
                {
                    if (bugsSize[startIndex] == 0 || step == 0)
                    {
                        continue;
                    }

                    if (direction != "left" && direction != "right")
                    {
                        bugsSize[startIndex] = 1;
                        continue;
                    }

                    bugsSize[startIndex] = 0;
                    if (direction == "left")
                    {
                        if (startIndex - step >= 0 && startIndex - step < sizeField)
                        {
                            for (int i = startIndex - step; i < sizeField; i -= step)
                            {
                                if (bugsSize[i] == 0)
                                {
                                    bugsSize[i] = 1;
                                    break;
                                }
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        if (startIndex + step >= 0 && startIndex + step < sizeField)
                        {
                            for (int i = startIndex + step; i < sizeField; i += step)
                            {
                                if (bugsSize[i] == 0)
                                {
                                    bugsSize[i] = 1;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", bugsSize));
        }
    }
}
