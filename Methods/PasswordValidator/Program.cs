using System;
using System.Linq;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (AreCharactersContains(password) && AreOnlyLettersAndDigit(password) && AreMoreThanTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }

            if (!AreCharactersContains(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!AreOnlyLettersAndDigit(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!AreMoreThanTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool AreCharactersContains(string pass)
        {
            return pass.Length >= 6 && pass.Length <= 10 ? true : false;
        }

        static bool AreOnlyLettersAndDigit(string pass)
        {
            bool isContains = true;

            for (int i = 0; i < pass.Length; i++)
            {
                if (!(Char.IsLetterOrDigit(pass[i])))
                {
                    isContains = false;
                    break;
                }
            }
            return isContains;
        }

        static bool AreMoreThanTwoDigits(string pass)
        {
            int counter = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i]))
                {
                    counter++;
                }
            }

            return counter >= 2 ? true : false;
        }
    }
}
