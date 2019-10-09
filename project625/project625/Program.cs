using System;

namespace project625
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool palindrome = true;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    palindrome = false;
                    break;
                }
            }
            Console.WriteLine(palindrome ? "YES" : "NO");
        }
    }
}
