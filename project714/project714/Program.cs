using System;

namespace project714
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int[] num = new int[N];

            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(ss[i]);
                num[i] = number;
            }
            if (N % 2 != 0)
            {
                N--;

                for (int j = 0; j < N; j++)
                {
                    int x = num[j];
                    num[j] = num[j + 1];
                    num[j + 1] = x;
                    Console.Write(num[j] + " " + num[j + 1] + " ");
                    j++;
                }
                Console.Write(num[N]);
            }
            else
            {
                for (int j = 0; j < N; j++)
                {
                    int x = num[j];
                    num[j] = num[j + 1];
                    num[j + 1] = x;
                    Console.Write(num[j] + " " + num[j + 1] + " ");
                    j++;
                }
            }
        }
    }
}
