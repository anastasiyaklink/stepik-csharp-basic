using System;

namespace project595
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            for (int x = 0; x <= 1000; x++)
            {
                if (x == 0 && e == 0 || x == e)
                    continue;
                else if (a * x * x * x + b * x * x + c * x + d / (x - e) == 0)
                    i++;
            }
            Console.Write(i);
        }
    }
}

