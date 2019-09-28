using System;

namespace project5105
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            int max2 = 0;
            while (N != 0)
            {
                if (N > max)
                {
                    max2 = max;
                    max = N;
                }
                else if (N > max2)
                {
                    max2 = N;
                }

                N = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(max2);
        }
    }
}
