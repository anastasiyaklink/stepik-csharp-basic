using System;

namespace project513
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
