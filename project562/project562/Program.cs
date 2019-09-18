using System;

namespace project562
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (N != 0)
            {
                if (N > 0)
                {
                    sum = sum + 1;
                }
                else
                {
                    sum = sum - 1;
                }

                N = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
