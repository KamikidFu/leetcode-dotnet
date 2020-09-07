using System;

namespace ConsoleApplication1.Question
{
    public class Q1395
    {
        public static void Run(int[] rating)
        {
            Solution s = new Solution();
            Console.WriteLine(s.NumTeams(rating));
        }
        public class Solution {
            public int NumTeams(int[] rating)
            {
                if (rating.Length < 2) return 0;
                int counter = 0;
                
                return counter;
            }
        }
    }
}