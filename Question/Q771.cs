using System;
using System.Linq;

namespace ConsoleApplication1.Question
{
    public class Q771
    {
        public static void Run(string J, string S)
        {
            Solution s =new Solution();
            Console.WriteLine(s.NumJewelsInStones(J,S));
        }
        public class Solution {
            public int NumJewelsInStones(string J, string S)
            {
                int rtn = 0;
                var jArr = J.ToCharArray();
                foreach (var s in S)
                {
                    if (jArr.Contains(s))
                    {
                        rtn++;
                    }
                }

                return rtn;
            }
        }
    }
}