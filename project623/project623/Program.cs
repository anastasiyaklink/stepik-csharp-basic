using System;

namespace project623
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (i != k - 1)
                {
                    Console.Write(s[i]);
                }
            }
        }
    }
}
