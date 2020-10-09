using System.Collections.Generic;

namespace LeetCodeSolution.Questions
{
    public class LC57II
    {
        public static void Run()
        {
            Solution s = new Solution();
            var res = s.FindContinuousSequence(9);
        }

        public class Solution
        {
            public int[][] FindContinuousSequence(int target)
            {
                int left = 1, right = 2;
                List<int[]> res = new List<int[]>();

                while (left < right)
                {
                    int sum = (left + right) * (right - left + 1) / 2;
                    if (sum == target)
                    {
                        int[] arr = new int[right - left + 1];
                        for (int k = left; k <= right; k++)
                        {
                            arr[k - left] = k;
                        }

                        res.Add(arr);
                        left++;
                    }
                    else if (sum < target)
                    {
                        right++;
                    }
                    else
                    {
                        left++;
                    }
                }

                return res.ToArray();
            }
        }
    }
}