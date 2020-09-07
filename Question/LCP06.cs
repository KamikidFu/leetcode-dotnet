using System;

namespace ConsoleApplication1.Question
{
    public class LCP06
    {
        public static void Run(int[] coins)
        {
            Solution s =new Solution();
            Console.WriteLine(s.MinCount(coins));
        }
        public class Solution {
            public int MinCount(int[] coins)
            {
                int rt = 0;
                // for (int i = 0; i < coins.Length; i++)
                // {
                //     rt += coins[i] / 2;
                //     if (coins[i] % 2 == 1)
                //     {
                //         rt += 1;
                //     }
                // }
                foreach (var coin in coins)
                {
                    rt += (coin + 1) / 2;
                }
                return rt;
            }
        }
    }
}