using System;

namespace test5119_2
{
    class MainClass
    {
        // https://written.ru/articles/science/automorph
        static string Next(string aString)
        {
            int n = aString.Length;

            if (aString[n - 1] != '5' && aString[n - 1] != '6')
            {
                return "error";
            }

            long a = Convert.ToInt64(aString);

            long b1 = a * a;

            string sb1 = b1.ToString();
            int c1 = Convert.ToInt32(sb1[sb1.Length - 1 - n].ToString());

            if (aString[n - 1] == '6' && c1 != 0)
            {
                c1 = 10 - c1;
            }

            return c1 + aString;
        }

        public static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());

            if (k >= 0)
            {
                Console.Write("0 ");
            }

            if (k >= 1)
            {
                Console.Write("1 ");
            }

            string a1 = "5";
            string a2 = "6";
            for (int i = 0; i < 7; i++)
            {
                if (string.Compare(a1, a2, StringComparison.Ordinal) > 0)
                {
                    string tmp = a1;
                    a1 = a2;
                    a2 = tmp;
                }

                if (k >= Convert.ToInt32(a1))
                {
                    if (a1[0] != '0') Console.Write(a1 + " ");
                }
                else break;

                if (k >= Convert.ToInt32(a2))
                {
                    if (a2[0] != '0') Console.Write(a2 + " ");
                }
                else break;

                a1 = Next(a1);
                a2 = Next(a2);
            }
        }
    }
}
