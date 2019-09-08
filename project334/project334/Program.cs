using System;

namespace project334
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Double P = a + b + c;
            Console.WriteLine(P);

        }
    }
}
