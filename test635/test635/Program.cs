using System;

namespace test635
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i <= s.Length-1; i++)
            {
                if (s[i] == 'a' || s[i] == 'A'||
                    s[i] == 'e' || s[i] == 'E'||
                    s[i] == 'i' || s[i] == 'I'||
                    s[i] == 'o' || s[i] == 'O'||
                    s[i] == 'u' || s[i] == 'U')
                {
                    sum++;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
