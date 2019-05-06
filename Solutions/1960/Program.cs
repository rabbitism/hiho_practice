using System;
using System.Collections.Generic;

namespace _1960
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Int32.TryParse(Console.ReadLine(), out count);
            for(int i = 0; i< count; i++)
            {
                long number = 0;
                Int64.TryParse(Console.ReadLine(), out number);
                long result = 0;
                Dictionary<int,int> dict = new Dictionary<int, int>{
                    {3,0},{5,0},{7,0}
                };
                while(number%3==0)
                {
                    number=number/3;
                    dict[3]++;
                }
                while(number%5==0)
                {
                    number=number/5;
                    dict[5]++;
                }
                while(number%7==0)
                {
                    number=number/7;
                    dict[7]++;
                }
                for(int m = 0; m<= dict[3]; m++)
                {
                    for(int n = 0; n<= dict[5]; n++)
                    {
                        for(int k = 0; k<=dict[7]; k++)
                        {
                            long temp = Convert.ToInt64(Math.Pow(3,m)*Math.Pow(5,n)*Math.Pow(7,k));
                            result+=temp;
                        }
                    }
                }
                System.Console.WriteLine(result);
            }

        }
    }
}
