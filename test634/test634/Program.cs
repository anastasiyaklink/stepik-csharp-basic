using System;

namespace test634
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            Console.WriteLine(s[0] == t[t.Length-1] ? "YES" : "NO");
         
        }
    }
}
