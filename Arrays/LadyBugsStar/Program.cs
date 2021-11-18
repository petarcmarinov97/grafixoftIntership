using System;
using System.Linq;

namespace LadyBugsStar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables 
            int sizeField = int.Parse(Console.ReadLine());
            int[] bugsField = new int[sizeField];
            int[] startPositions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //Checks for coincidence between startPositions and the bugsField length
            foreach (var index in startPositions)
            {
                if (index >= 0 && index < bugsField.Length)
                {
                    bugsField[index] = 1;
                }
            }

            //Command for the direction and the while loop
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                //Takes the start index, step and the direction
                int startIndex = int.Parse(command.Split()[0]);
                int step = int.Parse(command.Split()[2]);
                string direction = command.Split()[1];

                //Checks is the start index and the step are valid
                if (startIndex >= 0 && startIndex < bugsField.Length)
                {
                    //Checks does it have a bug on this position or no
                    if (bugsField[startIndex] == 0 || step == 0)
                    {
                        continue;
                    }
                    else
                    {
                        //When we have a bug on the start position, set the value to be equal to 0
                        bugsField[startIndex] = 0;

                        //Checks the directions and setting
                        if (direction == "left")
                        {
                            //Checks will it be in the field
                            //Check if the final position is free, setting the value to be equal to 1
                            //Moving the bug and leaving
                            if (startIndex - step >= 0 && startIndex - step < sizeField)
                            {
                                for (int i = startIndex - step; i < sizeField; i -= step)
                                {
                                    if (bugsField[i] == 0)
                                    {
                                        bugsField[i] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                        else if (direction == "right")
                        {
                            //Checks will it be in the field
                            //Check if the final position is free, setting the value to be equal to 1
                            //Moving the bug and leaving
                            if (startIndex + step >= 0 && startIndex + step < sizeField)
                            {
                                for (int i = startIndex + step; i < sizeField; i += step)
                                {
                                    if (bugsField[i] == 0)
                                    {
                                        bugsField[i] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            bugsField[startIndex] = 1;
                            continue;
                        }
                    }
                }
            }

            //Prints the final array with the bugs
            Console.WriteLine(string.Join(" ", bugsField));
        }
    }
}
