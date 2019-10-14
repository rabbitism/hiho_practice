using System;

namespace _1175
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split();
            int N = Convert.ToInt32(info[0]);
            int M = Convert.ToInt32(info[1]);
            int K = Convert.ToInt32(info[2]);

            int[] counts = new int[N + 1];

            string[] sources = Console.ReadLine().Split();
            foreach(string source in sources)
            {
                counts[Convert.ToInt32(source)] = 1;
            }

            foreach(int i in counts)
            {
                System.Console.WriteLine(i);
            }



        }
    }
}
