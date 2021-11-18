using System;
using System.Linq;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if(charactersContains(password) && onlyLettersAndDigit(password) && moreThanTwo(password))
            {
                Console.WriteLine("Password is valid");
            }

            if (!charactersContains(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!onlyLettersAndDigit(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!moreThanTwo(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static Boolean charactersContains(string pass)
        {
            if (pass.Length >= 6 && pass.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static Boolean onlyLettersAndDigit(string pass)
        {
            Boolean isTrue = true;

            for (int i = 0; i < pass.Length; i++)
            {

                if (!(Char.IsLetterOrDigit(pass[i])))
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
    
        static Boolean moreThanTwo(string pass)
        {
            bool isMore = false;
            int counter = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i]))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                isMore = true;
            }
            return isMore;
        }
    }
}
