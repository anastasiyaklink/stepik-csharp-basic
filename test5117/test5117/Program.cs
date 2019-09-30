using System;

namespace test5117
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = b; i >= a; i--)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                else if (i == a)
                {
                    Console.WriteLine("NO");

                }
            }
        }
    }
}
