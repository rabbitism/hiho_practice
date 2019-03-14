using System;
using System.Text;

namespace _1197
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
            while((line = Console.ReadLine())!=null)
            {
                StringBuilder sb = new StringBuilder();
                string[] tokens = line.Split();
                bool flag = false;
                for(int i = 0; i< tokens.Length; i++)
                {
                    if(string.IsNullOrWhiteSpace(tokens[i])) continue;
                    if(tokens[i]=="." || tokens[i]==",")
                    {
                        sb.Append(tokens[i]);
                        if(tokens[i]==".") flag = true;
                    }
                    else
                    {
                        if(sb.Length!=0) sb.Append(" ");
                        if(!flag) sb.Append(tokens[i].ToLower());
                        else
                        {
                            flag = false;
                            char[] token_array = tokens[i].ToCharArray();
                            token_array[0] = Char.ToUpper(token_array[0]);
                            sb.Append(new string(token_array));
                        }
                    }
                }
                char[] result = sb.ToString().ToCharArray();
                result[0] = Char.ToUpper(result[0]);
                System.Console.WriteLine(new string(result));

            }
        }
    }
}
