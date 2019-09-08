using System;

namespace project342
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x / 100 % 10);
        }
    }
}
