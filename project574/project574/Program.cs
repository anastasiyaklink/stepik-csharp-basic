using System;

namespace project574
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int divider = 2;
            int dividend = N;

            while (dividend !=1)
            {
                if (dividend % divider == 0)
                {
                    Console.Write(divider + " ");
                    dividend = dividend / divider;
                }
                else divider++;
            }
        }
    }
}
