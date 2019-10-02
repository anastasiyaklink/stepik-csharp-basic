using System;

namespace test5116
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          
            int N = Convert.ToInt32(Console.ReadLine());
            int N1 = N;
            int sum = 0;
           
            
            if (N1>=10)
            {
                while (N1 > 0)
                {
                    int digit = N1 % 10;
                    sum = sum + digit;
                    N1 = N1 / 10;
                }
                while (sum >=10)
                {
                    N1 = sum;
                    sum = 0;
                    while (N1 > 0)
                    {
                        int digit = N1 % 10;
                        sum = sum + digit;
                        N1 = N1 / 10;
                    }
                }
            }

            else if (N1 < 10)
            {
                sum = N1;
            }

            Console.WriteLine(sum);   
        }
    }

}
    
