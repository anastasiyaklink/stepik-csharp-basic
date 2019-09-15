using System;

namespace project531
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= N; i++)
            {
                fact = fact * i;
            }
            Console.Write(fact);
        }
    }
}
