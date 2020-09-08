using System;

namespace LeetCodeSolution.Questions
{
    public class Offer58
    {
        public static void Run(string str, int n)
        {
            Solution s = new Solution();
            Console.Write(s.ReverseLeftWords(str,n));
        }
        public class Solution {
            public string ReverseLeftWords(string s, int n)
            {
                if (n == 0) return s;
                n %= s.Length;
                string sub1 = s.Substring(0,n);
                string sub2 = s.Substring(n);
                return sub2+sub1;
                
                // StringBuilder stringBuilder = new StringBuilder();
                // for (int i = n ; i < s.Length; i++)
                // {
                //     stringBuilder.Append(s[i]);
                // }
                // for (int i = 0; i < n; i++)
                // {
                //     stringBuilder.Append(s[i]);
                // }
                // return stringBuilder.ToString();
                
                // return (s+s).Substring(n,s.Length);

                
            }
        }
    }
}