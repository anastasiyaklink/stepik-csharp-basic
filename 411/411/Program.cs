using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
            {
                Console.Write(a);
            }
            else
            {
                Console.Write(b);
            }
        }
    }
}
