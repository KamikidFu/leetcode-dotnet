using System;

namespace LeetCodeSolution.Questions
{
    public class Q1281
    {
        public static void Run(int n)
        {
            Solution s = new Solution();
            Console.WriteLine(s.SubtractProductAndSum(n));
        }

        public class Solution
        {
            public int SubtractProductAndSum(int n)
            {
                int flag = 100000;
                int div = n / flag;
                while (div<1)
                {
                    flag /= 10;
                    div = n / flag;
                }

                int mul = n/flag;
                int sum = n/flag;
                n -= (n / flag) * flag;
                flag /= 10;
                while (n >= 0 && flag >= 1)
                {
                    mul *= n / flag;
                    sum += n / flag;
                    n -= (n / flag) * flag;
                    flag /= 10;
                }
                return mul - sum;
            }
        }
    }
}