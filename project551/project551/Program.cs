using System;

namespace project551
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (N > 0)
            {
                int digit = N % 10;

                if (digit == 4)
                {
                    i = i + 1;
                }
                N = N / 10;
            }
            Console.WriteLine(i);
        }
    }
}
