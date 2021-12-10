using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int number = int.Parse(Console.ReadLine());
                PrintInt(number);
            }

            if (input == "real")
            {
                double number = double.Parse(Console.ReadLine());
                PrintReal(number);
            }

            if (input == "string")
            {
                string text = Console.ReadLine();
                PrintString(text);
            }
        }

        static void PrintInt(int number)
        {
            int output = number * 2;
            Console.WriteLine(output);
        }

        static void PrintReal(double number)
        {
            double output = number * 1.5;
            Console.WriteLine($"{output:f2}");
        }

        static void PrintString(string text)
        {
            string output = "$" + text + "$";
            Console.WriteLine(output);
        }
    }
}