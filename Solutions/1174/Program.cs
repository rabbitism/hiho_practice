using System;
using System.Collections.Generic;

namespace _1174
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTestCase = Int32.Parse(Console.ReadLine());
            for (int testCase = 0; testCase < countOfTestCase; testCase++)
            {
                string[] info = Console.ReadLine().Split();
                int countOfCourse = Int32.Parse(info[0]);
                int countOfRelation = Int32.Parse(info[1]);
                Dictionary<int, int> countOfPrerequisites = new Dictionary<int, int>();
                Dictionary<int, HashSet<int>> followingCourses = new Dictionary<int, HashSet<int>>();
                for (int i = 1; i <= countOfCourse; i++)
                {
                    countOfPrerequisites[i] = 0;
                    followingCourses[i] = new HashSet<int>();
                }
                for (int relationCount = 0; relationCount < countOfRelation; relationCount++)
                {
                    string[] relation = Console.ReadLine().Split();
                    int pre = Int32.Parse(relation[0]);
                    int follow = Int32.Parse(relation[1]);
                    countOfPrerequisites[follow]++;
                    followingCourses[pre].Add(follow);
                }
                Queue<int> queue = new Queue<int>();
                foreach (int key in countOfPrerequisites.Keys)
                {
                    if (countOfPrerequisites[key] == 0)
                    {
                        queue.Enqueue(key);
                    }
                }
                int count = 0;
                while (queue.Count != 0)
                {
                    var top = queue.Dequeue();
                    count++;
                    foreach (int followingCourse in followingCourses[top])
                    {
                        countOfPrerequisites[followingCourse]--;
                        if (countOfPrerequisites[followingCourse] == 0)
                        {
                            queue.Enqueue(followingCourse);
                        }
                    }
                }
                if (count == countOfCourse) Console.WriteLine("Correct");
                else Console.WriteLine("Wrong");

            }
        }
    }
}
