using System;

namespace project593
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 100;
            int i = x;
            int sum = 0;
            while (i <= 999)
            {
                if ((i / 100) + (i / 10 % 10) + (i % 10) == 8)
                {
                    sum = sum + 1;
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}