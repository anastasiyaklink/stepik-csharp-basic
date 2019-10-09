using System;

namespace project628
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //int countChar = s.Length;

            //int countA = 1;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == ' ' && s[i + 1] == ' ')
                {
                    continue;
                }

                //if ((s[i] != ' ' && s[i + 1] != ' ')||
                    //(s[i] == ' ' && s[i + 1] != ' ')||
                    //(s[i] != ' ' && s[i + 1] == ' '))
                //{
                   // Console.Write(s[i]);
                //}
             Console.Write(s[i]);
                 

            }

            ///Console.WriteLine(countA);
        }
    }
}
