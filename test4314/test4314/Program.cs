using System;

namespace test4314
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());
            if (a >= (b + c) || b >= (a + c) || c >= (a + b))
            {
                Console.WriteLine("impossible");
            }
            else if (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2) < 0 ||
                Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2) < 0 ||
                Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2) < 0)
            {
                Console.WriteLine("obtuse");
            }
            else if (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2) > 0 &&
                Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2) > 0 &&
                Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2) > 0)
            {
                Console.WriteLine("acute");
            }

            else Console.WriteLine("right");
        }
    }
}
Зкщоусе