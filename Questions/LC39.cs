using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolution.Questions
{
    public class LC39
    {
        public class Solution
        {
            public int MajorityElement(int[] nums)
            {
                if (nums.Length == 1) return nums[0];
                Dictionary<int, int> count = new Dictionary<int, int>();
                foreach (var num in nums)
                {
                    if (count.ContainsKey(num))
                    {
                        count[num]++;
                    }
                    else
                    {
                        count.Add(num,1);
                    }
                }

                var sorted = count.OrderByDescending(c => c.Value).ToDictionary(x => x.Key, x => x.Value);
                return sorted.Keys.First();
            }
        }

        public static void Run()
        {
            Solution s = new Solution();
            int[] nums = new[] {1, 2, 3, 2, 2, 2, 5, 4, 2};
            var res = s.MajorityElement(nums);
        }
    }
}