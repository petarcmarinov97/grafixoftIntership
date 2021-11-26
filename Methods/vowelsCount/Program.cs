using System;

namespace vowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.Write(Program.GetVowelsCount(word.ToLower()));
        }

        static int GetVowelsCount(string word)
        {
            int vowels = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'o' || word[i] == 'u' || word[i] == 'i')
                {
                    vowels++;
                }
            }

            return vowels;
        }
    }
}
