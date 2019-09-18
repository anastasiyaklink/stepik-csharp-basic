using System;

namespace project544
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            while ((a != 0) && (b != 0))
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }

            Console.WriteLine(Math.Max(a, b));
        }
    }
}


