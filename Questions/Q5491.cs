using System;

namespace LeetCodeSolution.Questions
{
    public class Q5491
    {
        public static void Run(int[][] mat)
        {
            Solution s = new Solution();
            Console.WriteLine(s.DiagonalSum(mat));
        }
        public class Solution {
            public int DiagonalSum(int[][] mat)
            {
                var height = mat.Length;
                var length = mat[0].Length;
                var counter = 0;
                var result = 0;
                while (counter < height)
                {
                    if (height / 2 == counter)
                    {
                        if (height % 2 == 0)
                        {
                            result += mat[counter][counter];
                            result += mat[counter][length -1 - counter];
                        }
                        else
                        {
                            result += mat[counter][counter];
                        }
                    }
                    else
                    {
                        result += mat[counter][counter];
                        result += mat[counter][length -1 - counter];
                    }
                    counter++;
                }

                return result;
            }
        }
    }
}