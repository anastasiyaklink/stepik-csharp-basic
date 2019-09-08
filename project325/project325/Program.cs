using System;

namespace project325
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int cost = ((a * 100) + b) * n;
            Console.WriteLine((cost/100)+ " " + (cost%100));
            

        }
    }
}