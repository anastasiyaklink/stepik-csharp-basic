using System;

namespace test5116
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int m = (n - 1) % 9 + 1;
            Console.Write(m);
        }
    }

}
    
