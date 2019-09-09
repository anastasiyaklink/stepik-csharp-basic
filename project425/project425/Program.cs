using System;

namespace project425
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            var d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                var x1 = (-b - Math.Sqrt(d)) / (2 * a);
                var x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else
            {
                if (d < 0)
                {
                    // ничего не выводим
                }
                else
                {
                    var x = (-b / (2 * a));
                    Console.WriteLine(x);
                }

            }


        }
    }
}
