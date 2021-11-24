using System;
using System.Collections.Generic;
using System.Linq;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine()
                .Split(new string[] { " " },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            char letterBefore = ' ';
            double number = 0;
            char letterAfter = ' ';
            double currSum = 0;
            string temp = string.Empty;
            List<double> totalSum = new List<double>();

            for (int i = 0; i < inputLine.Length; i++)
            {
                char[] currPart = inputLine[i].ToCharArray();
                letterBefore = currPart[0];
                letterAfter = currPart[currPart.Length - 1];

                for (int j = 1; j < currPart.Length - 1; j++)
                {
                    temp += currPart[j];
                }

                number = double.Parse(temp);
                temp = string.Empty;

                currSum = sumLetterBeforeAfter(letterBefore, letterAfter, number);
                totalSum.Add(currSum);
                currSum = 0;
            }

            Console.WriteLine($"{totalSum.Sum():f2}");
        }

        static double sumLetterBeforeAfter(char letterBefore,char letterAfter, double number)
        {
            double currSum = 0;
            if (Char.IsUpper(letterBefore))
            {
                int positionInAlphabet1 = char.ToUpper(letterBefore) - 64;
                currSum = currSum + (number / positionInAlphabet1);
            }
            else if (Char.IsLower(letterBefore))
            {
                int positionInAlphabet2 = char.ToUpper(letterBefore) - 64;
                currSum = currSum + (number * positionInAlphabet2);
            }

            if (Char.IsUpper(letterAfter))
            {
                int positionInAlphabet3 = char.ToUpper(letterAfter) - 64;
                currSum = currSum - positionInAlphabet3;
            }
            else if (Char.IsLower(letterAfter))
            {
                int positionInAlphabet4 = char.ToUpper(letterAfter) - 64;
                currSum = currSum + positionInAlphabet4;
            }

            return currSum;
        }
    }
}