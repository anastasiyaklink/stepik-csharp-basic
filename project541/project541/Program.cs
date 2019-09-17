using System;

namespace project541
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (a % 3 == 0)
            {
                a = a / 3;
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
