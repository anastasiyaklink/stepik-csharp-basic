using System;

namespace project614
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine());
            int code = c;
            char d = c;
            if (code >= 97 && code <= 122)
            {
                code = (char)(d - 32);
            }

            else if (code >= 65 && code <= 90)
            {
                code = (char)(d + 32);
            }

            Console.WriteLine((char)code);
        }
    }
}
