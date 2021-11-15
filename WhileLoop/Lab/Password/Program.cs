using System;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            string passwordConfirm = "";
            while(passwordConfirm != password)
            {
                passwordConfirm = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
