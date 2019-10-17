using System;

namespace test636
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();

            for (int i = 0; i <= s.Length - 1; i++)
            {
                Console.Write(s[i] != 'e' ? s[i]: 'i');
                // if (s[i] != 'e') Console.Write(s[i]);
                // else Console.Write("i");
            }
        }
    }
}
