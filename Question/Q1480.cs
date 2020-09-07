using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication1.Question
{
    public class Q1480
    {
        public static void Run(int[] nums)
        {
            Solution s = new Solution();
            Array.ForEach(s.RunningSum(nums),Console.WriteLine);
        }

        public class Solution
        {
            public int[] RunningSum(int[] nums)
            {
                var rtn = new int[nums.Length];
                rtn[0] = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    rtn[i] = rtn[i - 1] + nums[i];
                }
                return rtn;
            }
        }
    }
}