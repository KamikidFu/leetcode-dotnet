using System.Diagnostics.CodeAnalysis;

namespace LeetCodeSolution.Questions
{
    public class LC17
    {
        public static void Run()
        {
            Solution s = new Solution();
            var res = s.PrintNumbers(2);
        }   
    }
    public class Solution {
        public int[] PrintNumbers(int n)
        {
            int num = 1;
            for (int i = 0; i < n; i++)
            {
                num *= 10;
            }

            int[] res = new int[num - 1];
            for (int i = 1; i < num; i++)
            {
                res[i - 1] = i;
            }

            return res;
        }
    }
}