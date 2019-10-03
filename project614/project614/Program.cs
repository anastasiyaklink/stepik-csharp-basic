using System;

namespace project614
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine());
            Console.Write((char)(c >= 'A' && c <= 'Z' ? c + 32 : c - 32));
        }
    }
}
