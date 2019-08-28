using System;

namespace _1892
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dict = new int[26];
            string S = Console.ReadLine();
            string T = Console.ReadLine();
            foreach(var c in S)
            {
                dict[c - 'A']++;
            }
            foreach(var c in T)
            {
                dict[c - 'A']--;
            }
            for (int i = 0; i < dict.Length; i++)
            {
                if(dict[i]!=0){
                    System.Console.WriteLine(-1);
                    return;
                }
            }
            int count = 0;
            int i1 = S.Length - 1;
            int i2 = T.Length - 1;
            while(i1>=0 && i2>=0)
            {
                if(S[i1]==T[i2])
                {
                    count++;
                    i2--;
                    i1--;
                }
                else{
                    i1--;
                }
            }
            System.Console.WriteLine(S.Length-count);
        }
    }
}
