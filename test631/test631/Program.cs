using System;

namespace test631
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(k < s.Length ? s[k - 1].ToString() : "NO");
            //for (int i = 0; i <= s.Length - 1; i++)
            //{
            //    if (k > s.Length - 1)
            //    {
            //        Console.WriteLine("NO");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(s[k - 1]);
            //        break;
            //    }
            //}
        }
    }
}
