using System;
using System.Text.RegularExpressions;

namespace project627
{
    class MainClass
    {
        public static bool IsEnglishLetter(char ch)
        {
            return (ch >= 'a' && ch <= 'z')
                || (ch >= 'A' && ch <= 'Z');
        }

        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool valid = s.Length > 0;
            for (int i = 0; valid && i < s.Length; i++)
            {
                bool validForFirstChar = s[i] == '_' || IsEnglishLetter(s[i]);

                if ((i == 0 && !validForFirstChar)
                    || (i > 0 && !validForFirstChar && !char.IsDigit(s[i])))
                {
                    valid = false;
                }
            }
            //bool valid = Regex.IsMatch(s, "^[_a-zA-Z][_\\w]*$");
            Console.WriteLine(valid ? "YES" : "NO");
        }
    }
}
