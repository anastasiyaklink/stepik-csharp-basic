using System;

namespace project348
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int L = ((n - k % n) % n);
            Console.WriteLine(L);
        }
    }
}
