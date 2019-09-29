using System;

namespace test5112
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string n = Console.ReadLine();
            bool palindrome = true;
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - i - 1])
                {
                    palindrome = false;
                    break;
                }
            }
            Console.WriteLine(palindrome ? "YES" : "NO");
        }
    }
}
