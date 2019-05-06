using System;
using System.Collections.Generic;

namespace _1959
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Queue<int> qA = new Queue<int>();
            Queue<int> qB = new Queue<int>();
            string[] a = Console.ReadLine().Split();
            string[] b = Console.ReadLine().Split();
            for(int i = 0; i< N; i++)
            {
                qA.Enqueue(Convert.ToInt32(a[i]));
                qB.Enqueue(Convert.ToInt32(b[i]));
            }
            while(qA.Count!=0 && qB.Count!=0)
            {
                if(qA.Peek()>qB.Peek())
                {
                    qB.Dequeue();
                }
                else
                {
                    qA.Dequeue();
                }
            }
            System.Console.WriteLine(qA.Count+qB.Count);


        }
    }
}
