using System;

namespace project621
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int countChar = s.Length;

            int countA = 1;
            for (int index = 0; index <= countChar - 2; index++)
            {
                if (s[index] == ' ' && s[index+1] != ' ')
                {
                    countA++;
                }
            }

            Console.WriteLine(countA);
        }
    }
}