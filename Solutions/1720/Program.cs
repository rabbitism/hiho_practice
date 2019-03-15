using System;
using System.Collections.Generic;
using System.Text;

namespace _1720
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int dividend = int.Parse(numbers[0])*10;
            int divider = int.Parse(numbers[1]);
            HashSet<int> hs = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();
            while(true)
            {
                int q = dividend/divider;
                int r = dividend%divider;
                result.Add(q);
                if(hs.Contains(r)) break;
                else hs.Add(r);
                if(r==0) break;
                if(r*10<divider) result.Add(0);
                while(r<divider)
                {
                    r*=10;
                }
                dividend=r;
            }
            List<int> list = new List<int>(result);
            list.Sort();
            foreach(var element in list)
            {
                System.Console.Write(element);
            }
        }
    }
}
