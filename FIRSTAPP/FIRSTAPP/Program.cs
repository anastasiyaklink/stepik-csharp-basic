using System;

namespace FIRSTAPP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int x = a;
            a = b;
            b = x;

            // Допишите сюда
            // свой код

            Console.WriteLine(a + " " + b);


        }
    }
}
