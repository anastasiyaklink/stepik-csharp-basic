using System;

namespace project412
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            int Signx;

            if (x > 0)
            {
                Signx = 1;
            }
            else
            {
                if (x < 0)
                {
                    Signx = -1;
                }
                else
                {
                    Signx = 0;
                }

               
            }

            Console.Write(Signx);
        }
    }
}
