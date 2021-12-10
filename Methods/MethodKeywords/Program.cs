using System;

namespace MethodKeywords
{
    internal class Program
    {
        const int vConst=7;
        public readonly int vRead = vConst + 3;

        static void Main(string[] args)
        {
            int vOut = 3;
            int vIn = 5;
            int vRef;

            Console.WriteLine("Before -> " + vOut);
            TestOut(vOut);
            Console.WriteLine("After -> " + vOut);

        }

        static void TestOut(in int vIn)
        {
            vIn = 6;
        }
    }
}
