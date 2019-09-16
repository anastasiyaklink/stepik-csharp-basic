using System;

namespace project532
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int mult = 1;

            for (int i = a; i <= b; i++)
            {
                mult = mult * i;
            }
            Console.Write(mult);
        }
    }
}
