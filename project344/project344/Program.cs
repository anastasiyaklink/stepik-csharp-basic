using System;

namespace project344
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int an = a1 + d*(n - 1);
            Console.WriteLine(an);
        }
        
    }
}
