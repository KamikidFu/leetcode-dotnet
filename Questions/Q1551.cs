using System;

namespace LeetCodeSolution.Questions
{
    public class Q1551
    {
        public static void Run(int n)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MinOperations(n));
        }
        public class Solution {
            public int MinOperations(int n) {
                // n = 3
                // [1, 3, 5]
                // -> 2
                // n = 6
                // [1, 3, 5, 7, 9, 11] -> avg = 6
                // -> 1+3+5 -> 9
                
                // 纯数学运算
                // return n * n / 4;
                
                if (n < 2)
                {
                    return 0;
                }
                var rtn = 0;
                //TODO - Note: n&1 == 0 为偶数反之为奇数
                if ((n & 1) == 0)
                {
                    var mid1 = n / 2 - 1;
                    var mid2 = mid1 + 1;
                    var avg = (((2 * mid1) + 1) + ((2 * mid2) + 1)) / 2;
                    for (int i = mid2; i < n; i++)
                    {
                        rtn += (((2 * i) + 1) - avg);
                    }
                }
                else
                {
                    var mid = n / 2;
                    var avg = ((2 * mid) + 1);
                    for (int i = mid+1; i < n; i++)
                    {
                        rtn += (((2 * i) + 1) - avg);
                    }
                }

                return rtn;
            }
        }
    }
}