using System;

namespace project424
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("I");
                }
                else
                {
                    Console.WriteLine("IV");
                }


            }
            else
            {
                if(y > 0)
                {
                    Console.WriteLine("II");
                }
                else
                {
                    Console.WriteLine("III");
                }
            }

        }
    }
}
