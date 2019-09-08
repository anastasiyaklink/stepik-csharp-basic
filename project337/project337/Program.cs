using System;

namespace project337
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            int y = (int)(x * 10 % 10);
            Console.WriteLine(y);

        }
    }
}
