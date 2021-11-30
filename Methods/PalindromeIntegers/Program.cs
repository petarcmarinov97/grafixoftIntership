using System;
using System.Linq;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(isPalindrome(input).ToString().ToLower());

                input = Console.ReadLine();
            }
        }

        static bool isPalindrome(string input)
        {
            string reversedNumber = new string(input.ToCharArray().Reverse().ToArray());

            return reversedNumber == input;
        }
    }
}

