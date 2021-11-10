using System;

namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double metres = double.Parse(Console.ReadLine());
           double yardPrice = metres * 7.61;
           double discount = yardPrice * 0.18;
            Console.WriteLine("The final pricer is: " + (yardPrice-discount) + " lv.");
            Console.WriteLine("The discount is: " + discount + " lv.");
        }
    }
}
