using System;

namespace project613
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine());
            for (char w = c; w <= 'z'; w++)
            {
                Console.Write(w + " ");
            }
        }
    }
}
