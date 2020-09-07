using System;

namespace ConsoleApplication1.Question
{
    public class Q26
    {
        public static void Run(int[] nums)
        {
            Solution s = new Solution();
            Console.WriteLine(s.RemoveDuplicates(nums));
        }
        public class Solution {
            public int RemoveDuplicates(int[] nums)
            {
                if (nums.Length == 0) return 0;
                int i = 0;
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] != nums[j])
                    {
                        i++;
                        nums[i] = nums[j];
                    }
                }

                return i+1;
            }
        }
    }
}