using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace LeetCodeSolution.Questions
{
    public class LC29
    {
        // 1 2 3
        // 4 5 6
        // 7 8 9
        // 1,2,3,6,9,8,7,4,5
        public static void Run()
        {
            Solution s = new Solution();
            int[][] martix = new int[3][];
            martix[0] = new int[] {1, 2, 3};
            martix[1] = new int[] {4, 5, 6};
            martix[2] = new int[] {7, 8, 9};

            var res = s.SpiralOrder(martix);
        }

        public class Solution
        {
            public int[] SpiralOrder(int[][] matrix)
            {
                // int xMax = matrix.Length;
                // int yMax = matrix[0].Length;
                // if (xMax <= 0) return new int[0];
                // if (yMax <= 0) return new int[0];
                //
                // int[] rtn = new int[xMax * yMax];
                // int x = 0, y = 0, count = 0;
                //
                // while (count < rtn.Length)
                // {
                //     rtn[count] = matrix[x][y];
                //     count++;
                //
                //     // 左上
                //     if (x + 1 < xMax && y + 1 < yMax)
                //     {
                //         x++;
                //         continue;
                //     }
                //
                //     // 右上
                //     if (x + 1 > xMax && y + 1 < yMax)
                //     {
                //         y++;
                //         continue;
                //     }
                //
                //     // 左下
                //     if (x + 1 > xMax && y + 1 > yMax)
                //     {
                //         x--;
                //         continue;
                //     }
                //
                //     //右下
                //     if (x + 1 < xMax && y + 1 > yMax)
                //     {
                //         y--;
                //         continue;
                //     }
                //
                //     // 上
                //     if (x < xMax && y + 1 != yMax)
                //     {
                //         x++;
                //         continue;
                //     }
                //
                //     // 右
                //     if (y < yMax && x + 1 == xMax)
                //     {
                //         y++;
                //         continue;
                //     }
                //
                //     // 下
                //     if (x < xMax && y + 1 == yMax)
                //     {
                //         x--;
                //         continue;
                //     }
                //
                //     // 左
                //     if (y < yMax && x + 1 != xMax)
                //     {
                //         y--;
                //         continue;
                //     }
                // }
                //
                //
                // return rtn;
                if(matrix.Length == 0) return new int[0];
                int left = 0, right = matrix[0].Length - 1, top = 0, bottom = matrix.Length - 1, counter = 0;
                int[] rtn = new int[(right+1)*(bottom+1)];
                while (true)
                {
                    for (int i = left; i <= right; i++) rtn[counter++] = matrix[top][i];
                    if (++top > bottom) break;
                    for (int i = top; i <= bottom; i++) rtn[counter++] = matrix[i][right];
                    if (left > --right) break;
                    for (int i = right; i >= left; i--) rtn[counter++] = matrix[bottom][i];
                    if (top > --bottom) break;
                    for (int i = bottom; i >= top; i--) rtn[counter++] = matrix[i][left];
                    if (++left > right) break;
                }

                return rtn;
            }
        }
    }
}