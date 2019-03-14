using System;
using System.Collections.Generic;

namespace _1186
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersString = Console.ReadLine().Split();
            int P = Convert.ToInt32(numbersString[0]);
            int Q = Convert.ToInt32(numbersString[1]);
            List<int> p = GetDivisors(P);
            List<int> q = GetDivisors(Q);
            foreach(int x in p)
            {
                foreach(int y in q)
                {
                    System.Console.WriteLine(x+" "+y);
                }
            }
        }

        static List<int> GetDivisors(int n)
        {
            HashSet<int> hs = new HashSet<int>();
            double destination = Math.Sqrt(n);
            for(int i = 1; i<= destination; i++)
            {
                if(n%i==0)
                {
                    hs.Add(i);
                    hs.Add(n/i);
                }
            }
            List<int> list = new List<int>(hs);
            list.Sort();
            return list;
        }
    }
}
