using System;

namespace test632
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char a = Console.ReadLine()[0];
            char b = Console.ReadLine()[0];

            for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                char c = (char) i;
                Console.Write(c + " ");
            }
        }
    }
}
