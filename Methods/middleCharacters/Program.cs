using System;

namespace middleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(Program.middleCharacters(text));
        }

        static string middleCharacters(string text)
        {
            string result = "";
            if (text.Length % 2 == 0)
            {
                result += text[text.Length/2 - 1].ToString() + text[text.Length/2].ToString();
            }
            else
            {
                result += text[text.Length / 2];
            }
            return result;
        }
    }
}
