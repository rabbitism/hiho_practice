using System;

namespace _1288
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCaseAmount = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i< testCaseAmount; i++)
            {
                string[] parameters = Console.ReadLine().Split();
                int paragraphAmount = Convert.ToInt32(parameters[0]);
                int pageAmount = Convert.ToInt32(parameters[1]);
                int width = Convert.ToInt32(parameters[2]);
                int height = Convert.ToInt32(parameters[3]);
                string[] characterAmount_s = Console.ReadLine().Split();
                int[] characterAmounts = new int[characterAmount_s.Length];
                int sum = 0;
                for(int j = 0; j< characterAmount_s.Length; j++)
                {
                    characterAmounts[j] = Convert.ToInt32(characterAmount_s[j]);
                    sum+=characterAmounts[j];
                }
                Int64 maxPossible = pageAmount*width*height/sum;
                maxPossible = Math.Min(maxPossible, width);
                maxPossible = Math.Min(maxPossible, height);
                for(int j = (Int32)maxPossible; j>=1; j--)
                {
                    int lineAmount = 0;
                    for(int k = 0; k<characterAmounts.Length; k++)
                    {
                        int lines = GetLines(width, characterAmounts[k], j);
                        lineAmount+=lines;
                    }
                    int pages = GetLines(height, lineAmount, j);

                    if(pages>pageAmount) continue;
                    else
                    {
                        System.Console.WriteLine(j);
                        break;
                    }
                }
                

            }
        }

        static int GetLines(int width, int characters, int fontSize)
        {
            int charactersEachLine  = width/fontSize;
            int LineAmount = characters%charactersEachLine==0?(characters/charactersEachLine):(characters/charactersEachLine+1);
            return LineAmount;
        }
    }
}
