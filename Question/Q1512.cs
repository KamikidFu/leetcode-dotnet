using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Question
{
    public class Q1512
    {
        public static void Run(int[] nums)
        {
            Solution s = new Solution();
            Console.WriteLine(s.NumIdenticalPairs(nums));
        }
        public class Solution {
            public int NumIdenticalPairs(int[] nums)
            {
                var rtn = 0;
                Dictionary<int, IList<int>> dic = new Dictionary<int, IList<int>>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!dic.ContainsKey(nums[i]))
                    {
                        dic.Add(nums[i],new List<int>(){i});
                    }
                    else
                    {
                        dic[nums[i]].Add(i);
                    }
                }

                foreach (var e in dic.Values)
                {
                    rtn += (int) (e.Count) * (e.Count-1) / 2;
                }
                return rtn;
            }
        }
    }
}