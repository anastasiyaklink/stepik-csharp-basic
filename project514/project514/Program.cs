using System;

namespace project514
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = b; i >= a; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
