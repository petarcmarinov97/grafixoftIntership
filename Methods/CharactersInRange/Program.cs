using System;

namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            GetCharacters(first, second);
        }

        static void GetCharacters(char first, char second)
        {
            int asciiNumberFirst = (int)first;
            int asciiNumberSecond = (int)second;

            if (asciiNumberFirst < asciiNumberSecond)
            {
                for (int i = asciiNumberFirst + 1; i < asciiNumberSecond; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = asciiNumberSecond + 1; i < asciiNumberFirst; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
