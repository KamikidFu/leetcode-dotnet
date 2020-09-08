using System;

namespace LeetCodeSolution.Questions
{
    public class Q1313
    {
        public static void Run(int[] nums)
        {
            Solution s = new Solution();
            Array.ForEach(s.DecompressRLElist(nums), Console.WriteLine);
        }

        public class Solution
        {
            public int[] DecompressRLElist(int[] nums)
            {
                if (nums.Length % 2 == 1) return null;
                int length = 0;
                for (int i = 0; i < nums.Length; i+=2)
                {
                    length += nums[i];
                }

                int[] rtn = new int[length];
                int freq = 0;
                int num = 0;
                int arrPoint = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        freq = nums[i];
                    }
                    else
                    {
                        num = nums[i];
                        for (int j = 0; j < freq; j++)
                        {
                            rtn[arrPoint] = num;
                            arrPoint++;
                        }
                    }
                }

                return rtn;
            }
        }
    }
}