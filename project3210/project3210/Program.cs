﻿using System;

namespace project3210
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int n = num / 100;
            int u = num % 100 / 10;
            int m = num % 10;
            Console.WriteLine(m+""+u+""+n);

        }
    }
}
