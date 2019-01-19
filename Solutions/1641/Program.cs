using System;
using System.Collections.Generic;
using System.Text;

namespace _1641
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split(' ');
            int countOfLetters = Int32.Parse(number[0]);
            int countOfNumbers = Int32.Parse(number[1]);
            string[] letters = new string[countOfLetters];
            string[] numbers = new string[countOfNumbers];
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<char,char> d = new Dictionary<char, char>()
            {
                {'A','2'},{'B','2'},{'C','2'},{'D','3'},{'E','3'},{'F','3'},
                {'G','4'},{'H','4'},{'I','4'},{'J','5'},{'K','5'},{'L','5'},
                {'M','6'},{'N','6'},{'O','6'},{'P','7'},{'Q','7'},{'R','7'},
                {'S','7'},{'T','8'},{'U','8'},{'V','8'},{'W','9'},{'X','9'},
                {'Y','9'},{'Z','9'}
            };
            for(int i = 0; i< countOfLetters; i++)
            {
                letters[i] = Console.ReadLine();
            }
            for(int i = 0; i<countOfNumbers; i++)
            {
                numbers[i] = Console.ReadLine();
                dict.Add(numbers[i],0);
            }
            for(int i = 0; i< countOfLetters; i++)
            {
                string output = GetNumber(letters[i], d);
                if(dict.ContainsKey(output))
                {
                    dict[output]++;
                }
            }
            for(int i = 0; i< countOfNumbers; i++)
            {
                System.Console.WriteLine(dict[numbers[i]]);
            }
        }

        private static string GetNumber(string v, Dictionary<char,char> d)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in v)
            {
                sb.Append(d[c]);
            }
            return sb.ToString();
        }
    }
}
