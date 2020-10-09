using System;

namespace LeetCodeSolution.Questions
{
    public class LC58II
    {
        public static void Run()
        {
            Solution s = new Solution();
            var res = s.ReverseLeftWords("abcdefg",1);
            
        }
        public class Solution {
            public string ReverseLeftWords(string s, int n)
            {
                string half1 = s.Substring(n);
                string half2 = s.Substring(0, n);
                return half1 + half2;
            }
        }
    }
}