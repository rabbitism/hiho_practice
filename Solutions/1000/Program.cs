using System;

namespace _1000
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while((line = Console.ReadLine()) != null)
            {
                string[] tokens = line.Split(' ');
                int result = int.Parse(tokens[0])+int.Parse(tokens[1]);
                Console.WriteLine(result);
            }
        }
    }
}
