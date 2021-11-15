using System;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int demo;
            Boolean flag = true;
            
            while (word != "Stop")
            {
                word = Console.ReadLine();
                if(word == "Stop")
                {
                    flag = false;
                }
                if(flag == true)
                {
                    Console.WriteLine(word);
                }
                else
                {
                    break;
                }
                
            }
        }
    }
}
