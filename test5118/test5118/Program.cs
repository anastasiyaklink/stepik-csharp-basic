using System;

namespace test5118
{
    class MainClass
    {
        static int SumDividers(int N)
        {
            int sum = 1;

            double root = Math.Sqrt(N);

            for (int beforeRoot = 2; beforeRoot <= root; beforeRoot++)
            {
                if (N % beforeRoot == 0)
                {
                    sum = sum + beforeRoot;

                    int afterRoot = N / beforeRoot;

                    if (beforeRoot < afterRoot)
                    {
                        sum = sum + afterRoot;
                    }
                }
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());

            for (int n = 1; n < k; n++)
            {
                int m = SumDividers(n);

                if (n < m && SumDividers(m) == n)
                {
                    Console.WriteLine(n + " " + m);
                }
            }
        }
    }
}
