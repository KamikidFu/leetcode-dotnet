using System;

namespace LeetCodeSolution.Questions
{
    public class Q1470
    {
        public static void Run(int[] nums, int n)
        {
            Solution s = new Solution();
            Array.ForEach(s.Shuffle(nums,n),Console.WriteLine);
        }
        public class Solution {
            public int[] Shuffle(int[] nums, int n) {
                //TODO write in-place solution
                int pointer = 0;
                int[] ret = new int[nums.Length];
                for(int i=0;i<n;i++)
                {
                    ret[pointer++] = nums[i];
                    ret[pointer++] = nums[i + n];
                }
                return ret;
            }
        }
    }
}