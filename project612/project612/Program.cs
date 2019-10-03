using System;

namespace project612
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine());
            for (char w = 'a'; w <= c; w++)
            {
                Console.Write(w+" ");
            }

        }
    }
}
