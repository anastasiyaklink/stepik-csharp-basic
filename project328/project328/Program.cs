using System;

namespace project328
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 432;
            int y = x / 100;
            x = (x % 100) * 10;
            x = x + y;
            Console.WriteLine(x);

        }
    }
}
