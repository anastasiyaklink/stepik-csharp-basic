using System;

namespace project552
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int N1 = N;
            int sum = 0;

            while (N1 > 0)
            {
                int digit = N1 % 10;
                sum = sum + digit; // sum = sum+digit
                N1 = N1 / 10; //N1=N1/10
            }
            Console.WriteLine(sum);
            Console.WriteLine((N % sum == 0) ? "YES" : "NO");
        }
    }
}
