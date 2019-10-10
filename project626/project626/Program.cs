using System;

namespace project626
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int flag = 0;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                for (int j = 0; j <= s.Length - 1; j++)
                {
                    
                    if (i!=j && s[i] == s[j])
                    {
                        flag++;

                        if (flag == 1)
                        {
                            Console.Write(s[j]);
                            break;
                        }

                    }

                }
                //if (flag == 1) break;
            }
        }
    }
}
