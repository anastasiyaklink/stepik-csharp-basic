using System;

namespace project584
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int i = 1;

            while (s != Console.ReadLine())
            {
                i++;
            }

            Console.WriteLine(i);
        }
    }
}
