using System;

namespace project581
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = N-1; i>=1; i--)
            {
                if (N%i==0)
                {
                    Console.WriteLine(i);
                    break; 
                }
            }
        }
    }
}
