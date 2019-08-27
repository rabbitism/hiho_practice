using System;

namespace _1049
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] preOrder = Console.ReadLine().ToCharArray();
            char[] inOrder = Console.ReadLine().ToCharArray();
            int n = preOrder.Length;
            char[] postOrder = new char[n];
            Build(preOrder, inOrder, postOrder, 0, n-1, 0, n-1, 0, n-1);
            System.Console.WriteLine(new string(postOrder));

        }

        public static void Build(char[] preOrder, char[] inOrder, char[] postOrder, int prel, int prer, int inl, int inr, int postl, int postr)
        {
            if(prel==prer)
            {
                postOrder[postr] = preOrder[prel];
                return;
            }
            if(prel>prer)
            {
                return;
            }
            char root = preOrder[prel];
            int rootIndex=inl;
            for(int i = inl; i<=inr; i++)
            {
                if(inOrder[i]==root)
                {
                    rootIndex=i;
                    break;
                }
            }
            int leftLength = rootIndex-inl;
            int rightLength = inr - rootIndex;
            postOrder[postr] = root;
            Build(preOrder, inOrder, postOrder, prel+1, prel+leftLength, inl, rootIndex-1, postl, postl+leftLength-1);
            Build(preOrder, inOrder, postOrder, prer-rightLength+1, prer, rootIndex+1, inr, postr-rightLength, postr-1);
            

        }


    }
}
