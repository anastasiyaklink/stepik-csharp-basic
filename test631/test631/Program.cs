using System;

namespace test631
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(k - 1 < s.Length ? s[k - 1].ToString() : "NO");
        }
    }
}
