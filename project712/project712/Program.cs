using System;

namespace project712
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            for (int i = 0; i < N; i++)
            {
                int num = Convert.ToInt32(ss[i]);
                if (num % 3 == 0) Console.Write(num + " ");
            }
        }
    }
}
