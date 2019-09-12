using System;

namespace project515
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (Math.Pow(i, 2) <= (Math.Pow(N,2)))
                {
                    Console.WriteLine(Math.Pow(i, 2));
                }
            }
        }
    }
}