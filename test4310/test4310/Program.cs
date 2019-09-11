using System;

namespace test4310
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            if ((x2 == x1 + 1 && y2 == y1 + 2) ||
                (x2 == x1 + 1 && y2 == y1 - 2) ||
                (x2 == x1 - 1 && y2 == y1 + 2) ||
                (x2 == x1 - 1 && y2 == y1 - 2) ||
                (x2 == x1 + 2 && y2 == y1 + 1) ||
                (x2 == x1 + 2 && y2 == y1 - 1) ||
                (x2 == x1 - 2 && y2 == y1 + 1) ||
                (x2 == x1 - 2 && y2 == y1 - 1))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
