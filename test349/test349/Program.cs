using System;

namespace test349
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string abcd = Console.ReadLine();
            string dabc = abcd[3] + abcd.Substring(0, 3);
            string cdab = dabc[3] + dabc.Substring(0, 3);
            string bcda = cdab[3] + cdab.Substring(0, 3);
            int max1 = Math.Max(Convert.ToInt32(abcd), Convert.ToInt32(dabc));
            int max2 = Math.Max(Convert.ToInt32(cdab), Convert.ToInt32(bcda));
            int max = Math.Max(max1, max2);
            Console.WriteLine(max);
        }
    }
}

