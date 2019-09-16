using System;

namespace project534
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int mult = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    mult = mult * i;
                }
            }
            Console.WriteLine(mult);
        } 
    }
}
