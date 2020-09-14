using System;

namespace LeetCodeSolution.Questions
{
    public class Q1365
    {
        public static void Run(int[] nums)
        {
            Solution s =new Solution();
            Array.ForEach(s.SmallerNumbersThanCurrent(nums),Console.WriteLine);
        }
        public class Solution {
            public int[] SmallerNumbersThanCurrent(int[] nums)
            {
                int[] rtn = new int[nums.Length];
                
                Array.Copy(nums,rtn,nums.Length);
                
                Array.Sort(nums);

                for (int i = 0; i < rtn.Length; i++)
                {
                    var num = rtn[i];
                    rtn[i] = Array.IndexOf(nums, num);
                }

                return rtn;
            }
        }
    }
}