using System;

namespace project561
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (N != 0)
            {
               if ( N%2==0 && N % 3 != 0)
                {
                    sum = sum + N;
                }
               N = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
