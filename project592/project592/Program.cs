using System;

namespace project592
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= n; x++)
            {

                if (x % c == 0 && x % d != 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
