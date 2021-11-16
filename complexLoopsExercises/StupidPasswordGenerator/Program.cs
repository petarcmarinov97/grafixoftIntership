using System;

namespace complexLoopsExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string password = "";

            //first char
            for (int c1 = 1; c1 < n; c1++)
            {
                //second char
                for (int c2 = 1; c2 < n; c2++)
                {
                    //trird char
                    for (int asciic3 = 97; asciic3 < 97 + l; asciic3++)
                    {
                        char c3 = Convert.ToChar(asciic3);

                        //fourth char
                        for(int asciic4 = 97; asciic4 < 97 + l; asciic4++)
                        {
                            char c4 = Convert.ToChar(asciic4);

                            //fifth char
                            for (int c5 = Math.Max(c1, c2) + 1; c5<= n; c5++)
                            {
                                password = $"{c1}{c2}{c3}{c4}{c5}";
                                Console.Write($"{password} ");
                            }
                        }   
                    }
                }
            }
        }
    }
}
