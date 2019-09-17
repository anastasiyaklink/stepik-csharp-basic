using System;

namespace project543
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            int i = 0;
            while (k < N)
            {
                k = 2 * k;
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
