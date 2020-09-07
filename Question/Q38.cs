using System;

namespace ConsoleApplication1.Question
{
    public class Q38
    {
        public static void Run(int n)
        {
            Solution s = new Solution();
            Console.WriteLine(s.CountAndSay(n));
        }
        public class Solution {
            public string CountAndSay(int n)
            {
                string rtn = "1";
                for (int i = 0; i < n-1; i++)
                {
                    rtn = Say(rtn);
                }

                return rtn;
            }

            public string Say(string str)
            {
                string rtn = string.Empty;
                int count = 0;
                char cur = char.MinValue;
                for (int i = 0; i < str.Length; i++)
                {
                    if (!cur.Equals(str[i]))
                    {
                        if (count != 0)
                        {
                            rtn += count.ToString() + cur;
                        }
                        cur = str[i];
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                rtn += count.ToString() + cur;

                return rtn;
            }
        }
    }
}