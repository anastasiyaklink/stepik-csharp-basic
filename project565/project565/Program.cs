using System;

namespace project565
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int N1 = N;
            while (N != 0)
            {
                if ((N > 0 && N1 < 0) || (N < 0 && N1 > 0))
                {
                    sum = sum + 1;
                }
                N1 = N;
                N = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
