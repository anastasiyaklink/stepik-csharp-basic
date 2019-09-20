using System;

namespace project555
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int k = 0;
            int km = 1;

            //  Find k = max number of significant bits
            while (km < n)
            {
                km *= 2;
                k++;
            }

            int nk = n;

            // Skip highest 0, unless it's the only 0
            if (nk != 0 && nk < km)
            {
                km /= 2;
                k--;
            }

            while (k >= 0)
            {
                if (nk >= km)
                {
                    Console.Write(1);
                    nk -= km;
                }
                else
                {
                    Console.Write(0);
                }

                km /= 2;
                k--;
            }
        }
    }
}
