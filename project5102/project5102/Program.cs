using System;

namespace project5102
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int num;
            int max = -(int)Math.Pow(10, 6);
            for (int i = 1; i <= N; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
