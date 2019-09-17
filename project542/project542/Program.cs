using System;

namespace project542
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            int i = 0;
            while (x <= N)
            {
                Console.WriteLine(x);
                x = x * 2;
                i++;
            }   
        }
    }
}
