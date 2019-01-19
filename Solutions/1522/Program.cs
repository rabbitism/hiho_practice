using System;

namespace _1522
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Int32.Parse(Console.ReadLine());
            if(count==0) return;
            int TP = 0;
            int FP = 0;
            int FN = 0;
            for(int i = 0; i< count; i++)
            {
                string sample = Console.ReadLine();
                if(sample[0]=='+' && sample[2]=='+') TP++;
                if(sample[0]=='+' && sample[2]=='-') FP++;
                if(sample[0]=='-' && sample[2]=='+') FN++;
            }
            double p = (TP+FP)==0?1.0:1.0*TP/(TP+FP);
            double r = (TP+FN)==0?1.0:1.0*TP/(TP+FN);
            double f1 = (p+r)==0?2*p*r:2*p*r/(p+r);
            System.Console.WriteLine(f1.ToString("0.00%"));
        }
    }
}
