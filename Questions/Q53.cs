using System;

namespace LeetCodeSolution.Questions
{
    public class Q53
    {
        public static void Run(int[] nums)
        {
            Solution s =new Solution();
            Console.Write(s.MaxSubArray(nums));
        }
        public class Solution {
            public int MaxSubArray(int[] nums)
            {
                //TODO 分治法解题
                if (nums.Length == 1) return nums[0];
                int max = nums[0];
                int sum = 0;
                foreach (var num in nums)
                {
                    //但凡sum不为正数，就把和放到当前数上
                    //因为如果sum是负数了，负数加任何正数都比当前的正数小
                    if (sum > 0)
                    {
                        sum += num;
                    }
                    else
                    {
                        sum = num;
                    }

                    max = sum > max ? sum : max;
                }

                return max;
            }
        }
    }
}