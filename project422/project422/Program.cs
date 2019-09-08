using System;

namespace project422
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if ((x >= -3 && x <= 1) || (x >= 5 && x <= 9)) 
                {
                    Console.WriteLine ("YES");
                }
            else
                {
                    Console.WriteLine("NO");
                  
                }

           


        }
    }
}
