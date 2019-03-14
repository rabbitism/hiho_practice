using System;
using System.Collections.Generic;

namespace _1615
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] positives = new int[N];
            int[] negatives = new int[N];
            int sum = 0;
            for(int i = 0; i< N; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                for(int j = 0; j< N; j++)
                {
                    int number = Convert.ToInt32(numbers[j]);
                    if(number>0) positives[j]+=number;
                    else negatives[j]+=number;
                }
            }
            List<int> list = new List<int>();
            for(int i = 0; i< N; i++)
            {
                sum+=positives[i];
                sum+=negatives[i];
                list.Add(positives[i]+negatives[i]);
            }
            list.Sort();
            for(int i = 0; i< list.Count-1; i+=2)
            {
                int sum2 = list[i]+list[i+1];
                if(sum2<0)
                {
                    sum-=2*sum2;
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
