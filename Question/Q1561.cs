using System;

namespace ConsoleApplication1.Question
{
    public class Q1561
    {
        public static void Run(int[] piles)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MaxCoins(piles));
        }
        public class Solution {
            public int MaxCoins(int[] piles)
            {
                Array.Sort(piles);
                int times = (int) piles.Length / 3;
                int start = piles.Length - 2;
                int rtn = 0;
                while (times > 0)
                {
                    rtn += piles[start];
                    start -= 2;
                    times--;
                }

                return rtn;
            }
        }
    }
}