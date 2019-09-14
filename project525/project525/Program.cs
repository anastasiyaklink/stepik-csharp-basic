using System;

namespace project525
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
                if (num == 0)
                {
                    sum = sum + 1;

                    //Console.WriteLine("YES";
                   // Console.WriteLine("NO");
                }
            }
            if (sum>0)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
        } 
    }
}
