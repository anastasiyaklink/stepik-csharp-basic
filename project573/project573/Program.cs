using System;

namespace project573
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int y = 0;
            int j = 0;
            for (int i = 1; i <= N; i++)
            {
                int sum = 0;
                
                for (j = i; j > 0; j = j / 10)
                {
                    sum = sum + (j % 10);
                }

                if (y < sum)
                {
                    y = sum;

                    x = i;
                }
            }
            Console.WriteLine(x + " " + y);
        }
    }
}



