using System;
using System.Linq;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (ContainsCharacters(password) && HasOnlyLettersOrDigits(password) && HasMoreThanTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }

            if (!ContainsCharacters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!HasOnlyLettersOrDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!HasMoreThanTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool ContainsCharacters(string pass)
        {
            return pass.Length >= 6 && pass.Length <= 10;
        }

        static bool HasOnlyLettersOrDigits(string pass)
        {
            bool contains = true;

            for (int i = 0; i < pass.Length; i++)
            {
                if (!(Char.IsLetterOrDigit(pass[i])))
                {
                    contains = false;
                    break;
                }
            }

            return contains;
        }

        static bool HasMoreThanTwoDigits(string pass)
        {
            int counter = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i]))
                {
                    counter++;
                }
            }

            return counter >= 2;
        }
    }
}
