using System;

namespace project624
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for (int index = 0; index <= s.Length - 1; index++)
            {
                if (s[index] == 'x')
                {
                    Console.WriteLine("x");
                    break;
                }

                if (s[index] == 'w')
                {
                    Console.WriteLine("w");
                    break;
                }

                if (index == s.Length - 1)
                {
                    Console.WriteLine("-1");
                }
            }
        }
    }
}
