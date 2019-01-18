using System;

namespace _1678
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLine = Convert.ToInt32(Console.ReadLine());
            string[] versions = new string[countOfLine];
            for(int i = 0; i< countOfLine; i++)
            {
                versions[i] = Console.ReadLine();
            }
            Array.Sort(versions, (s1, s2)=>{
                int[] version1 = Array.ConvertAll(s1.Split('.'), new Converter<string,int>(StrToInt));
                int[] version2 = Array.ConvertAll(s2.Split('.'), new Converter<string,int>(StrToInt));
                int max = Math.Max(version1.Length, version2.Length);
                for(int i = 0; i< max; i++)
                {
                    if(i<version1.Length && i< version2.Length)
                    {
                        if(version1[i]==version2[i]) continue;
                        if(version1[i]<version2[i]) return -1;
                        if(version1[i]>version2[i]) return 1;
                    }
                    else if(i>=version1.Length) return -1;
                    else return 1;
                }
                return 0;
            });
            for(int i = 0; i< countOfLine; i++)
            {
                System.Console.WriteLine(versions[i]);
            }

        }

        private static int StrToInt(string input)
        {
            return int.Parse(input);
        }
    }
}
