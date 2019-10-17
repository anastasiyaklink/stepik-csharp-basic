using System;

namespace test637
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();

            for (int i = 0; i <= s.Length - 1; i++)
            {
                Console.Write (s[i] >= '0' && s[i] <= '9' ? s[i] + " " : "");
            }
        }
    }
}
