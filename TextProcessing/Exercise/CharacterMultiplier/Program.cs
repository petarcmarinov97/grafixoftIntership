using System;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string str1 = input[0];
            string str2 = input[1];

            int minLength = Math.Min(str1.Length, str2.Length);
            int maxLength = Math.Max(str1.Length, str2.Length);
            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += CharsASCII(str1[i], str2[i]);
            }

            if (str1.Length != str2.Length)
            {
                string longer = str1.Length > str2.Length ? longer = str1 : longer = str2;
                for(int i = minLength; i< maxLength; i++)
                {
                    sum += longer[i];
                }
            }
            Console.WriteLine(sum);

        }

        static int CharsASCII(char letterOne, char letterTwo)
        {
            int multiply = letterOne*letterTwo;
            return multiply;
        }
    }
}
