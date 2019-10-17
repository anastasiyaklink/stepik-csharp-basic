using System;

namespace test637
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();

            foreach (char c in s)
            {
                Console.Write (Char.IsDigit(c) ? c + " " : "");
            }
        }
    }
}
