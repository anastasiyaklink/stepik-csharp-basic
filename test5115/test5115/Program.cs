using System;

namespace test5115
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double min = Math.Pow(10, 6);
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (min > num)
                {
                    min = num;
                    sum = 1;
                }
                else if (num == min)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
