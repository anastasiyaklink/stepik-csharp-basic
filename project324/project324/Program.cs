using System;

namespace project324
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32((x * x) * (x * x) * (x * x));
            Console.WriteLine(y);
        }
    }
}
