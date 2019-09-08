using System;

namespace project416
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int x0 = x / 100000 % 10;
            int x1 = x / 10000 % 10;
            int x2 = x / 1000 % 10;
            int x3 = x / 100 % 10;
            int x4 = x / 10 % 10;
            int x5 = x % 10;
            if (x0 + x1 + x2 == x3 + x4 + x5)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
