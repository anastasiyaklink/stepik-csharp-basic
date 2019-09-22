using System;

namespace project582
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = 0;
            while (N <= 100)
            {
                N = Convert.ToInt32(Console.ReadLine());
                if (N >= 10 && N <= 100) Console.WriteLine(N);

                if (N < 10) continue;

                if (N > 100) break;
            }
        }
    }
}
