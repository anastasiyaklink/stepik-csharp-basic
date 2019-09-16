using System;

namespace project533
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
                if (i % 10 == 7)
                {
                    mult = mult * i;
                }
            }
            Console.Write(mult);
        }
    }
}
