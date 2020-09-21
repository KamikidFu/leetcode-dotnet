using System;

namespace LeetCodeSolution.Questions
{
    public class Q5503
    {
        public static void Run(int[] arr)
        {
            Solution s = new Solution();
            Console.WriteLine(s.SumOddLengthSubarrays(arr));
        }

        public class Solution
        {
            public int SumOddLengthSubarrays(int[] arr)
            {
                int res = 0;
                int lEven, lOdd, rEven, rOdd;
                for (int i = 0; i < arr.Length; i++)
                {
                    lOdd = (i + 1) / 2;
                    lEven = i / 2 + 1;
                    rOdd = (arr.Length - i) / 2;
                    rEven = (arr.Length - i + 1) / 2;
                    res += (lOdd * rOdd + lEven * rEven) * arr[i];
                }

                return res;
            }
        }
    }
}