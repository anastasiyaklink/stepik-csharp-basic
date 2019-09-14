using System;

namespace project524
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int num;

            for (int i = 1; i <= N; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 10 == 0)
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
   