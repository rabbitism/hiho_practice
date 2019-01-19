using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _1603
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"@[a-zA-Z]*";
            foreach(Match match in Regex.Matches(input, pattern))
            {
                if(match.Value.Length>1)
                {
                    System.Console.Write(match.Value.Remove(0,1)+" ");
                }
            }
            
        }
    }
}
