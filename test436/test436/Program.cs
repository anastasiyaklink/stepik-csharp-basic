using System;

namespace test436
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Double a = Convert.ToDouble(Console.ReadLine());
            Double b = Convert.ToDouble(Console.ReadLine());
            Double c = Convert.ToDouble(Console.ReadLine());
            Double desk = (Math.Ceiling(a / 2) + Math.Ceiling(b / 2) + Math.Ceiling(c / 2));
            Console.WriteLine(desk);
        }
    }
}
