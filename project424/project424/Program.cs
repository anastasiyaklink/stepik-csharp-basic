using System;

namespace project424
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("4");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("2");
                }
                else
                {
                    Console.WriteLine("3");
                }
            }
        }
    }
}
