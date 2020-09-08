using System;

namespace LeetCodeSolution.Questions
{
    public class Q14
    {
        public static void Run(string[] strs)
        {
            Solution s = new Solution();
            Console.WriteLine(s.LongestCommonPrefix(strs));
        }

        private class Solution {
            public string LongestCommonPrefix(string[] strs)
            {
                var rtn = string.Empty;
                if (strs.Length == 0)
                {
                    return rtn;
                }
                var firstString = strs[0];
                for (int i = 0; i < firstString.Length; i++)
                {
                    var c = firstString[i];
                    for (int j = 1; j < strs.Length; j++)
                    {
                        try
                        {
                            if (strs[j][i] != c)
                            {
                                return rtn;
                            }
                        }
                        catch (Exception e)
                        {
                            return rtn;
                        }
                    }
                    rtn += c;
                }
                return rtn;
            }
        }
    }
}