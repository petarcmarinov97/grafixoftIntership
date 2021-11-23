using System;
using System.Text;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] inputLine = Console.ReadLine().ToCharArray();
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < inputLine.Length; i++)
            {
                int currCharNumber = (int)inputLine[i] + 3;
                output.Append((char)currCharNumber);
            }

            Console.WriteLine(output);
        }
    }
}
