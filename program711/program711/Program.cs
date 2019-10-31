using System;

namespace program711
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
                if (i % 3 == 0) Console.Write(ss[i] + " ");
            }
        }
    }
}

