using System;
using System.Linq;
using System.Collections.Generic;

namespace ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            List<char> output = new List<char>();
            char previousChar = ' ';

            for (int i = 0; i < text.Length; i++)
            {
                if (previousChar != text[i])
                {
                    output.Add(text[i]);
                }
                previousChar = text[i];
            }

            Console.WriteLine(string.Join("", output));
        }
    }
}
