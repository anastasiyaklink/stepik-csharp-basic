using System;

namespace project554
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            while (N > 0)
            {
                Console.Write(N % 2);
                 N = N / 2;
            }
        }
    }
}
