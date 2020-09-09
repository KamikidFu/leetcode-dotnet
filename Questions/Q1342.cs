using System;

namespace LeetCodeSolution.Questions
{
    public class Q1342
    {
        public static void Run(int num)
        {
            Solution s = new Solution();
            Console.WriteLine(s.NumberOfSteps(num));
        }
        public class Solution {
            public int NumberOfSteps (int num)
            {
                // int counter = 0;
                // while (num != 0)
                // {
                //     if (num % 2 == 0)
                //     {
                //         num /= 2;
                //     }
                //     else
                //     {
                //         num -= 1;
                //     }
                //     counter++;
                // }
                //
                // return counter;
                int count = 0;
                while (num != 0)
                {
                    count++;
                    num = (num & 1) == 1 ? num & -2 : num >> 1;
                }
                return count;
            }
        }
    }
}