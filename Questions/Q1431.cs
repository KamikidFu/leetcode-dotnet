using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolution.Questions
{
    public class Q1431
    {
        public static void Run(int[] candies, int extraCandies)
        {
            Solution s = new Solution();
            Array.ForEach(s.KidsWithCandies(candies,extraCandies).ToArray(),Console.WriteLine);
        }
        
        public class Solution {
            public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
            {
                var max = candies.Max();
                List<bool> ret = new List<bool>();
                foreach (var c in candies)
                {
                    ret.Add(c+extraCandies>=max);
                }

                return ret;
            }
        }
    }
}