using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listofNames = Console.ReadLine().Split(", ").ToList();
            List<string> validUsers = new List<string>();

            foreach (var user in listofNames)
            {
                if (user.Length >= 3 && user.Length <= 16)
                {
                    bool validUsernames = ValidateUsers(user);
                    if (validUsernames == true)
                    {
                        validUsers.Add(user);
                    }
                }
            }

            Console.WriteLine(string.Join("\n", validUsers));
        }

        static bool ValidateUsers(string user)
        {
            foreach (var symbol in user)
            {
                if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
