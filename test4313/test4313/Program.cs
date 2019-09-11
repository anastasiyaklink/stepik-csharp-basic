using System;

namespace test4313
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string abcd = Console.ReadLine();
            if (abcd[0] == abcd[3] && abcd[1] == abcd[2])
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
