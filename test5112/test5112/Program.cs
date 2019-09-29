using System;

namespace test5112
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            //  Количество цифр в числе
            int numDigits = (int) Math.Ceiling(Math.Log10(a));
            int halfDigits = numDigits / 2;
            int b = 0;
            for (int i = 0; i < halfDigits; i++)
            {
                b = b * 10 + a % 10;
                a = a / 10;
            }

            //  При нечетном количестве цифр среднюю цифру не учитываем,
            //  она ни на что не влияет
            if (numDigits % 2 != 0)
            {
                a = a / 10;
            }

            Console.WriteLine(a == b ? "YES" : "NO");
        }
    }
}
