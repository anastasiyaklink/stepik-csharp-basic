using System;

namespace test435
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double k = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());
            double n = Math.Ceiling(k / m);
            Console.WriteLine(n);

        }
    }
}
