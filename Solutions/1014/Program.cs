using System;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            Trie trie= new Trie();
            for(int i = 0; i<N; i++)
            {
                trie.Add(Console.ReadLine());
            }
            int M = Int32.Parse(Console.ReadLine());
            for(int i = 0; i< M; i++)
            {
                System.Console.WriteLine(trie.Query(Console.ReadLine()));
            }
        }
    }

    public class Trie
    {
        public class Node
        {
            public int sum;
            public Node[] children = new Node[26];

            public Node(int i)
            {
                sum = i;
            }
        }

        private Node root;

        public Trie()
        {
            root = new Node(0);
        }

        public void Add(string s)
        {
            Node p = root;
            for(int i = 0; i< s.Length; i++)
            {
                int child = s[i]-'a';
                if(p.children[child]==null)
                {
                    p.children[child] = new Node(1);
                }
                else{
                    p.children[child].sum++;
                }
                p = p.children[child];
            }
        }

        public int Query(string s)
        {
            Node p = root;
            for(int i = 0; i< s.Length; i++)
            {
                int child = s[i]-'a';
                if(p.children[child]==null)
                {
                    return 0;
                }
                else{
                    p = p.children[child];
                }
            }
            return p.sum;
        }
    }
}
