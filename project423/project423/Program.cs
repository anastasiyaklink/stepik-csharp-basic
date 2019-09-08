using System;

namespace project423
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("3");
            }
            else
            {
                if (a == b || b == c || c == a)
                {
                    Console.WriteLine("2");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}