using System.Text;

namespace LeetCodeSolution.Questions
{
    public class LC05
    {
        public static void Run()
        {
            Solution s =new Solution();
            string str = "We are happy.";
            var res = s.ReplaceSpace(str);
        }
        public class Solution {
            public string ReplaceSpace(string s) {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    if (c == ' ')
                    {
                        sb.Append("%20");
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }

                return sb.ToString();
            }
        }
    }
}