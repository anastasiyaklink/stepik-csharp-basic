using System;

namespace Project346
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int n = (num / 100 % 10);
            int u = (num / 10 % 10);
            int m = (num % 10);
            Console.WriteLine(n + u + m);
        }
    }
}
7