using System;

namespace test4311
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int n1 = N / 100;
            int n2 = N % 100 / 10;
            int n3 = N % 10;
            if ((n1 < n2) && (n2 < n3))
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
