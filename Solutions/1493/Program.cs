using System;
using System.Collections.Generic;

namespace _1493
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> primes = GetPrimes(number);
            HashSet<int> hs = new HashSet<int>(primes);
            for(int i = 0; i< primes.Count; i++)
            {
                int a = number-primes[i];
                if(hs.Contains(a))
                {
                    System.Console.WriteLine(primes[i]+" "+a);
                    break;
                }
            }
        }

        static List<int> GetPrimes(int number)
        {
            int[] primes = new int[number];
            List<int> result = new List<int>();
            for(int i = 0; i< number; i++)
            {
                primes[i]=i;
            }
            for(int i = 2; i< number; i++)
            {
                if(primes[i]!=0)
                {
                    for(int j = 2*i; j<number; j+=i)
                    {
                        primes[j]=0;
                    }
                }
            }
            for(int i =2 ; i<number; i++)
            {
                if(primes[i]!=0) result.Add(i);
            }
            return result;
        }
    }
}
