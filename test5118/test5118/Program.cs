using System;

namespace test5118
{
    class MainClass
    {
        static int SumFactors(int N)
        {
            int sum = 1;

            double root = Math.Sqrt(N);

            for (int i = 2; i < root; i++)
            {
                if (N % i == 0)
                {
                    sum = sum + i + N / i;
                }
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());

            for (int n = 1; n < k; n++)
            {
                int m = SumFactors(n);

                if (n < m && SumFactors(m) == n)
                {
                    Console.WriteLine(n + " " + m);
                }
            }
        }
    }
}
