using System;

namespace project583
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            while (x <= n)
            {
               int divider = n / x;
                x++;
                if (divider % c == 0 && divider % d != 0)
                {
                    Console.WriteLine(divider);
                    break;
                }
            }
        }
    }
}
