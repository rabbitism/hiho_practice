using System;

namespace _1761
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parameters = Console.ReadLine().Split();
            int n = Convert.ToInt32(parameters[0]);
            int t = Convert.ToInt32(parameters[1])%2;
            string[] numbers = Console.ReadLine().Split();
            if(t==0)
            {
                for(int i = 0; i< numbers.Length; i++)
                {
                    System.Console.WriteLine(numbers[i]);
                }
            }
            else
            {
                for(int i = numbers.Length-1; i>=0; i--)
                {
                    System.Console.WriteLine(numbers[i]);
                }
            }
            
            
        }
    }
}
