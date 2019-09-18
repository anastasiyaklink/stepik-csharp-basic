using System;

namespace project563
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            int i = 0;
            while (N != 0)
            {
                sum = sum + N;
                i = i + 1;
                N = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum/i);
        }
    }
}
