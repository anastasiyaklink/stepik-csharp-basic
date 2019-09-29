using System;

namespace test5112
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char[] array = n.ToCharArray();
            Array.Reverse(array);
            string n2 = new string(array);
            Console.WriteLine(n == n2 ? "YES" : "NO");
        }
    }
}
