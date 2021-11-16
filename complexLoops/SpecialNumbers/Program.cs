using System;

namespace SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //First Digit
            for(int d1 =1; d1<=9; d1++)
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
                            if (n%d1 ==0 && n%d2==0 && n%d3 ==0 && n%d4==0)
                            {
                                Console.Write($"{d1}{d2}{d3}{d4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
