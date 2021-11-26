using System;

namespace middleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(GetMiddleCharacters(text));
        }

        static string GetMiddleCharacters(string text)
        {
            string result = "";
            result = text.Length % 2 == 0 
                ? text[text.Length / 2 - 1].ToString() + text[text.Length / 2].ToString()
                : result += text[text.Length / 2];

            return result;
        }
    }
}
