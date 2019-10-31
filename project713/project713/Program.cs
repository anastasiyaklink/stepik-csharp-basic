using System;

namespace project713
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int[] num = new int[N];
            int sum = 0;
            int x = Convert.ToInt32(Math.Pow(10, 9));
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(ss[i]);
                num[i] = number;

                if (number > x)
                {
                    sum++;
                }
                x = number;
            }
            Console.Write(sum);
        }
    }
}
