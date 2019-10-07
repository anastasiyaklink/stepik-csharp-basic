using System;

namespace project622
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int countChar = s.Length;

            for (int index = countChar - 1; index >= 0; index--)
            {
                Console.Write(s[index]);
            }

        }
    }
}
