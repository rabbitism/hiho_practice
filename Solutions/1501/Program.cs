using System;
using System.Text;

namespace _1501
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i< count; i++)
            {
                string variable = Console.ReadLine();
                if(variable.Contains("_"))
                {
                    bool flag = false;
                    StringBuilder sb = new StringBuilder();
                    for(int j = 0; j< variable.Length; j++)
                    {
                        if(variable[j]=='_')
                        {
                            flag = true;
                            continue;
                        }

                        else
                        {
                            if(flag)
                            {
                                sb.Append(Char.ToUpper(variable[j]));
                                flag = false;
                            }
                            else
                            {
                                sb.Append(variable[j]);
                            }
                        }
                    }
                    System.Console.WriteLine(sb.ToString());

                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    for(int j=0;j<variable.Length; j++)
                    {
                        if(variable[j]<='Z')
                        {
                            sb.Append("_");
                            sb.Append(Char.ToLower(variable[j]));
                        }
                        else
                        {
                            sb.Append(variable[j]);
                        }
                    }
                    System.Console.WriteLine(sb.ToString());
                }
            }
        }
    }
}
