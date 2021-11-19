using System;

namespace VowelsSUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int sum = 0;
            int a = 1;
            int e = 2;
            int i = 3;
            int o = 4;
            int u = 5;

            for (int b = 0; b < word.Length; b++)
            {

                if (word[b] == 'a')
                {
                    sum += a;
                }
                else if (word[b] == 'e')
                {
                    sum += e;
                }
                else if (word[b] == 'i')
                {
                    sum += i;
                }
                else if (word[b] == 'o')
                {
                    sum += o;
                }
                else if (word[b] == 'u')
                {
                    sum += u;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
