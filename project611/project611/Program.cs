using System;

namespace project611
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(c >= '0' && c <= '9' ? "YES" : "NO");
        
        }
    }
}
