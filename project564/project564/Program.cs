using System;

namespace project564
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
                if (N>N1)
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
