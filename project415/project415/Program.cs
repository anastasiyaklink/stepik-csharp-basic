using System;

namespace project415
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            string s = x.ToString();
            Console.WriteLine(
                s[0] != s[1]
                && s[1] != s[2]
                && s[0] != s[2]
                ? "YES" : "NO");
        }
    }
}
