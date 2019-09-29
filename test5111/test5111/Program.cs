using System;

namespace test5111
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if (Convert.ToInt32(Console.ReadLine()) == 0)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
