using System;

namespace project332
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Double R = Convert.ToDouble(Console.ReadLine());
            Double Pi = 3.14;
            Double S = Math.Pow(R, 2) * Pi;
            Console.WriteLine(S);
        }
    }
}
