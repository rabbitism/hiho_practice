using System;
using System.Collections.Generic;

namespace _1850
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int sum = 0;
            int count = 1;
            for(int i = 1; i< s.Length; i++)
            {
                if(s[i]!=s[i-1])
                {
                    sum+=count/2;
                    count=1;
                }
                else
                {
                    count++;
                }
            }
            sum+=count/2;
            System.Console.WriteLine(sum);;
        }
    }
}
