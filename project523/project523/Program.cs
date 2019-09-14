using System;

namespace project523
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int num;

            for (int i = 1; i <= N; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2==0 && num % 3 !=0)
                {
                    sum = sum + num;
                }
                  
            }
            Console.WriteLine(sum);
        }
    }
}
