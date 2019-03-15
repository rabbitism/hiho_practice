using System;
using System.Text;

namespace _1842
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] counts = Console.ReadLine().Split();
            int N = int.Parse(counts[0]);
            int M = int.Parse(counts[1]);
            if((N>M*2+2)||(M>N*2+2)) System.Console.WriteLine("-1");
            int max = Math.Max(N, M);
            int min = Math.Min(N, M);
            char maxChar = N>M?'A':'B';
            char minChar = N>M?'B':'A';
            int single = Math.Max(0, max-min*2);
            max = max-single;
            int dble = 2*min-max;
            int triple = max-min;
            StringBuilder sb = new StringBuilder();
            string triple_s = new string(new char[]{maxChar, maxChar,minChar});
            string double_s = new string(new char[]{maxChar, minChar});
            for(int i = 0; i< triple; i++)
            {
                sb.Append(triple_s);
            }
            for(int i = 0; i< dble; i++)
            {
                sb.Append(double_s);
            }
            for(int i = 0; i< single; i++)
            {
                sb.Append(maxChar);
            }
            System.Console.WriteLine(sb.ToString());
            
            

        }
    }
}
