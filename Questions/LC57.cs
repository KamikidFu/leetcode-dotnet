using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolution.Questions
{
    public class LC57
    {
        public static void Run()
        {
            Solution s = new Solution();
            int[] nums = new[] {2, 7, 11, 15};

            var res = s.TwoSum(nums, 9);
        }

        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                // List<int> keys = nums.ToList();
                // for (int i = 0; i < nums.Length; i++)
                // {
                //     if (keys.Contains(target - nums[i]))
                //     {
                //         return new[] {target - nums[i], nums[i]};
                //     }
                // }
                //
                // return null;
                int start = 0, end = nums.Length - 1;
                while (start < end)
                {
                    int sum = nums[start] + nums[end];
                    if (sum < target)
                    {
                        start++;
                    }else if (sum > target)
                    {
                        end--;
                    }
                    else
                    {
                        return new int[] {nums[start], nums[end]};
                    }
                }

                return new int[0];
            }
        }
    }
}