using System;

namespace project343
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 8 + 2 * 5;
            int y = (x % 10) + 14;
            x = (y / 10) + 3;
            int c = x - y;
            Console.WriteLine(c);
        }
    }
}

