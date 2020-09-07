using System;

namespace ConsoleApplication1.Question
{
    public class Offer64
    {
        public static void Run(int n)
        {
            Solution s = new Solution();
            Console.WriteLine(s.SumNums(n));
        }

        public class Solution
        {
            public int SumNums(int n)
            {
                bool ans = n > 0 && (n += SumNums(n - 1)) > 0;
                return n;
            }
        }
    }
}