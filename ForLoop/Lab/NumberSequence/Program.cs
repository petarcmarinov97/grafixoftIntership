using System;

namespace NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            //	-2,147,483,648 to 2,147,483,647
            // Math.Min(,)

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                minNumber = Math.Min(number, minNumber);
                maxNumber = Math.Max(number, maxNumber);
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
