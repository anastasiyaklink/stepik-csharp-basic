using System;

namespace project32
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = (a + b + c);
            int mult = (a * b * c);
            Console.WriteLine(sum + " " + mult);

        }
    }
    
}
