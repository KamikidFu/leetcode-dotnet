using System;

namespace ConsoleApplication1.Question
{
    public class Q665
    {
        public static void Run(int[] nums)
        {
            Solution s = new Solution();
            Console.WriteLine(s.CheckPossibility(nums));
        }
        public class Solution {
            public bool CheckPossibility(int[] nums)
            {
                if (nums.Length < 3) return true;
                var flag = 0;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i+1])
                    {
                        flag++;
                        if (i == 0) continue;
                        if (flag > 1) return false;
                        if (nums[i + 1] > nums[i - 1])
                        {
                            nums[i] = nums[i + 1];
                        }
                        else
                        {
                            nums[i + 1] = nums[i];
                        }
                    }
                }
                return true;
            }
        }
    }
}