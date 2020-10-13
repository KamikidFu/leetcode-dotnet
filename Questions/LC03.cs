using System.Collections.Generic;

namespace LeetCodeSolution.Questions
{
    public class LC03
    {
        public static void Run()
        {
            Solution s = new Solution();
            var res = s.FindRepeatNumber(new []{2,3,1,0,2});
            
        }
        public class Solution {
            public int FindRepeatNumber(int[] nums) {
                Dictionary<int,int> map = new Dictionary<int, int>();
                foreach (var num in nums)
                {
                    if (map.ContainsKey(num))
                    {
                        return num;
                    }
                    else
                    {
                        map.Add(num,1);
                    }
                }

                return -1;
            }
        }
    }
}