using System;

namespace project5104
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int speed;
            int max = 0;
            int min = 30;
            bool found = false;

            for (int i = 1; i <= N; i++)
            {
                speed = Convert.ToInt32(Console.ReadLine());

                if (speed > max)
                {
                    max = speed;
                }
                if (speed < min)
                {
                    found = true;
                }
            }
            Console.Write(max + " " + (found ? "YES" : "NO"));
        }
    }
}
