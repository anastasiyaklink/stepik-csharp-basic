using System;

namespace test635
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == 'a' ||
                    s[i] == 'e' ||
                    s[i] == 'i' ||
                    s[i] == 'o' ||
                    s[i] == 'u' )
                {
                    sum++;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
