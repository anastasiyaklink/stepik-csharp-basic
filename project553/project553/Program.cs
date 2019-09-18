using System;

namespace project553
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            while (N > 0)
            {
                int num = N % 10;
                Console.Write(num);
                N = N / 10;
            }
        }
    }
}
