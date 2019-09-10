using System;

namespace test439
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            if ((Math.Abs(a1 - b1) == 1 && Math.Abs(a2 - b2) == 1) ||
                a1 == b1 && (Math.Abs(a2 - b2)==1) ||
                (a2 == b2) && (Math.Abs(a1-b1)==1))
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
