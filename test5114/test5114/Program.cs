using System;

namespace test5114
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int an = a;
            if (n == 0)
            {
                an = 1;
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    an = an * a;
                }
            }
            Console.WriteLine(an);
        }
    }
}