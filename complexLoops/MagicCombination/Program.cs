using System;

namespace MagicCombination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());
            string result = "";
            
            //First Digit
            for (int d1 = 1; d1 <= 9; d1++)
            {
                //Second Digit
                for (int d2 = 1; d2 <= 9; d2++)
                {
                    //Trird Digit
                    for (int d3 = 1; d3 <= 9; d3++)
                    {
                        //Fourth Digit
                        for (int d4 = 1; d4 <= 9; d4++)
                        {
                            //Fifth Digit
                            for (int d5 = 1; d5 <= 9; d5++)
                            {
                                //Sixth Digit
                                for (int d6 = 1; d6 <= 9; d6++)
                                {
                                    if ((d1 * d2 * d3 * d4 * d5 * d6) == magicNumber)
                                    {
                                        result = $"{d1}{d2}{d3}{d4}{d5}{d6}";
                                        Console.Write(result + " ");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
