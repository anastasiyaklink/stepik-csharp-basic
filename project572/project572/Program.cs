using System;

namespace project572
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                int x = i;

                while (x > 0)
                {
                    int digit = x % 10;

                    if (digit == 7) sum = sum + 1;
                    x = x / 10;
                }
            }
            Console.WriteLine(sum);
        }
    }
}






