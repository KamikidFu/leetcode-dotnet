using System;

namespace LeetCodeSolution.Questions
{
    public class LCP17
    {
        public static void Run(string s)
        {
            Solution st = new Solution();
            Console.Write(st.Calculate(s));
        }
        public class Solution {
            public int Calculate(string s)
            {
                int x = 1;
                int y = 0;
                foreach (var c in s)
                {
                    if (c == 'A')
                    {
                        x = CalculateA(x, y);
                    }
                    else
                    {
                        y = CalculateB(x, y);
                    }
                }

                return x + y;
            }

            private int CalculateA(int x, int y)
            {
                return 2 * x + y;
            }

            private int CalculateB(int x, int y)
            {
                return 2 * y + x;
            }
        }
    }
}