using System;

namespace project571
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                int sum = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) sum = sum + 1;
                }

                if (sum >= k) Console.Write(i + " ");
            }
        }
    }
}

