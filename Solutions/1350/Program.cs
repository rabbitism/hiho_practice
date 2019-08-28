using System;
using System.Collections.Generic;
using System.Linq;

namespace _1350
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int>[] dict = new HashSet<int>[7];
            for (int i = 0; i < dict.Length; i++)
            {
                dict[i] = new HashSet<int>();
            }
            int[] holder = new int[6];
            Construct(dict, holder, 0);
            int n = Int32.Parse(Console.ReadLine());
            List<int>[] lists = new List<int>[7];
            for (int i = 0; i < lists.Length; i++)
            {
                lists[i] = new List<int>(dict[i]);
                lists[i].Sort();
            }
            for (int i = 0; i <= 5; i++)
            {
                if(i>5||n-i>6 || n-i<0) continue;
                List<int> hour = lists[i];
                List<int> minute = lists[n - i];
                foreach (int h in hour)
                {
                    if (h >= 24) continue;
                    foreach (int m in minute)
                    {
                        if (m >= 60) continue;
                        string hstr = h < 10 ? "0" + h : h.ToString();
                        string mstr = m < 10 ? "0" + m : m.ToString();
                        System.Console.WriteLine(hstr+":"+mstr);
                    }
                }

            }
        }

        public static void Construct(HashSet<int>[] dict, int[] holder, int start)
        {
            if (start > holder.Length) return;
            int sum = 0;
            for (int i = 0; i < holder.Length; i++)
            {
                sum += (int)Math.Pow(2, i) * holder[i];
            }
            dict[holder.Sum()].Add(sum);
            for (int i = start; i < holder.Length; i++)
            {
                Construct(dict, holder, start + 1);
                holder[start] = 1;
                Construct(dict, holder, start + 1);
                holder[start] = 0;
            }
        }
    }
}
