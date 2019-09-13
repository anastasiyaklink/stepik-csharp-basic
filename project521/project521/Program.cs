using System;

namespace project521
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int del = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    del = del + 1;
                }

            }
            Console.WriteLine(del);
        }
    }
}
