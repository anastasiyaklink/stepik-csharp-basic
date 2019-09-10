using System;

namespace test432
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 30;
            int b = 6;
            a = a / 2 * b;
            int c;
            if (a > b)
            {
                c = a - 3 * b;
            }
            else
            {
                c = a + 3 * b;
            }

            Console.WriteLine(c);
        }
    }
}
