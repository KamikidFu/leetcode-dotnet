using System;

namespace ConsoleApplication1.Question
{
    public class Q1486
    {
        public static void Run(int n, int start)
        {
            Solution s = new Solution();
            Console.WriteLine(s.XorOperation(n,start));
        }
        public class Solution {
            public int XorOperation(int n, int start)
            {
                //TODO 补充关于xor异或的做法
                int res = 0;
                for (int i = 0; i < n; i++)
                {
                    res ^= (start + 2 * i);
                }

                return res;
            }
        }
    }
}