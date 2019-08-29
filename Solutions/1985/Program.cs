using System;
using System.Collections.Generic;

namespace _1985
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int count = Int32.Parse(Console.ReadLine());
            int[] amounts = new int[3];
            for (int i = 0; i < count; i++)
            {
                string[] transaction = Console.ReadLine().Split();
                if(transaction[0]=="CREATE")
                {
                    int id = Int32.Parse(transaction[1]);
                    int amount = Int32.Parse(transaction[2]);
                    dict[id] = amount;
                    amounts[2] += amount;
                }
                else if(transaction[0]=="CANCEL")
                {
                    int id = Int32.Parse(transaction[1]);
                    amounts[1] += dict[id];
                    amounts[2] -= dict[id];
                }
                else if(transaction[0]=="PAY")
                {
                    int id = Int32.Parse(transaction[1]);
                    amounts[0] += dict[id];
                    amounts[2] -= dict[id];
                }
            }
            System.Console.WriteLine(amounts[0]+" "+amounts[1]+" "+amounts[2]);
        }
    }
}
