using System;
using System.Net;

namespace LeetCodeSolution.Questions
{
    public class Q807
    {
        public static void Run(int[][] grid)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MaxIncreaseKeepingSkyline(grid));
        }

        public class Solution
        {
            public int MaxIncreaseKeepingSkyline(int[][] grid)
            {
                int rtn = 0;
                int xLength = grid.Length;
                int yLength = grid[0].Length;
                int[] xArr = new int[grid.Length];
                int[] yArr = new int[grid[0].Length];
                int x = 0, y = 0;
                // build arr
                for (int i = 0; i < xLength * yLength; i++)
                {
                    x = i / yLength;
                    y = i % yLength;
                    // update x
                    if (grid[x][y] > xArr[x])
                    {
                        xArr[x] = grid[x][y];
                    }
                    // update y
                    if (grid[x][y]>yArr[y])
                    {
                        yArr[y] = grid[x][y];
                    }
                }
                
                // calculate build
                for (int i = 0; i < xLength * yLength; i++)
                {
                    x = i / yLength;
                    y = i % yLength;
                    if (xArr[x] < yArr[y])
                    {
                        rtn += (xArr[x] - grid[x][y]);
                    }
                    else
                    {
                        rtn += (yArr[y] - grid[x][y]);
                    }
                }

                return rtn;
            }
        }
    }
}