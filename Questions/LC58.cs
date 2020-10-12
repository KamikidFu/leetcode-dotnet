﻿using System.Text;
using System.Text.RegularExpressions;

namespace LeetCodeSolution.Questions
{
    public class LC58
    {
        public static void Run()
        {
            Solution s = new Solution();
            var res = s.ReverseWords("the   sky   is blue ");
        }
        public class Solution {
            public string ReverseWords(string s)
            {
                // var trimed = Regex.Replace(s.Trim(), @"\s+", " ");
                // var arr = trimed.Split(' ');
                // StringBuilder sb = new StringBuilder();
                // for (int i = arr.Length - 1; i >= 0; i--)
                // {
                //     sb.Append(arr[i]);
                //     sb.Append(" ");
                // }
                // return sb.ToString().Trim();
                string temp = s.Trim();
                int start = temp.Length - 1;
                int end = temp.Length - 1;
                string res = "";
                while (start >= 0)
                {
                    while (start >= 0 && temp[start] != ' ')
                    {
                        start--;
                    }

                    res += temp.Substring(start+1, end-start) + " ";
                    while (start >= 0 && temp[start] == ' ')
                    {
                        start--;
                    }

                    end = start;
                }

                return res.Trim();
            }
        }
    }
}