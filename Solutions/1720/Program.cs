using System;
using System.Collections.Generic;
using System.Text;

namespace _1720
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int dividend = Int32.Parse(input[0]);
            int divider = Int32.Parse(input[1]);
            List<int> list= new List<int>();
            while(true)
            {
                while(dividend/divider==0)
                {
                    dividend*=10;
                }
                int result = dividend/divider;
                int residue = dividend%divider;
                if(list.Contains(result))
                {
                    break;
                }
                else
                {
                    list.Add(result);
                    dividend = residue;
                }
                if(residue == 0) break;
            }
            list.Sort();
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i< list.Count; i++)
            {
                sb.Append(i.ToString());
            }
            System.Console.WriteLine(sb.ToString());
        }
    }
}
