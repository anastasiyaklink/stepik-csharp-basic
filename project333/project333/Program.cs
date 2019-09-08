using System;

namespace project333
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int bit = Convert.ToInt32(Console.ReadLine());
            double kbait = bit / (Math.Pow(2, 13));
            Console.WriteLine(kbait);
        }
    }
}
