using System;

namespace project624
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == 'x' || s[i] == 'w')
                {
                    Console.WriteLine(s[i]);
                    break;
                }

                if (i == s.Length - 1)
                {
                    Console.WriteLine("-1");
                }
            }
        }
    }
}
