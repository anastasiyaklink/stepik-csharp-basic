using System;

namespace project594
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 10;
            int i = x;
            while (i <= 99)
            {
                if (i / 10 * (i % 10) * 2 == i) Console.WriteLine(i + ",");
                i++;
            }
        }
    }
}

