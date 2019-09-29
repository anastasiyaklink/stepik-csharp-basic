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
            int base10 = (int)Math.Pow(10, numDigits - 1);
            int halfDigits = numDigits / 2;

            bool palindrome = true;
            for (int i = 0;
                i < halfDigits;
                // убираем два разряда из степени десятки
                // (число становится меньше на два разряда каждую итерацию)
                i++, base10 = base10 / 100)
            {
                int leftDigit = a / base10;
                int rightDigit = a % 10;
                if (leftDigit != rightDigit)
                {
                    palindrome = false;
                    break;
                }
                a = a - leftDigit * base10;
                a = a / 10;
            }

            Console.WriteLine(palindrome ? "YES" : "NO");
        }
    }
}
