using System;

namespace test434
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = (n + 1);
            if (n1 % 2 == 0)
            {
                Console.WriteLine(n1);              
            }
            else
            {
                Console.WriteLine(n1 + 1);
            }
        }
    }
}
