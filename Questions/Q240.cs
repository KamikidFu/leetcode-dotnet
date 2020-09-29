namespace LeetCodeSolution.Questions
{
    public class Q240
    {
        public static void Run()
        {
            Solution s = new Solution();
            int[][] matrix = new int[5][];
            matrix[0] = new[] {1, 4, 7, 11, 15};
            matrix[1] = new[] {2, 5, 8, 12, 19};
            matrix[2] = new[] {3, 6, 9, 16, 22};
            matrix[3] = new[] {10, 13, 14, 17, 24};
            matrix[4] = new[] {18, 21, 23, 26, 30};
            // matrix[0] = new[] {-1, 3};
            var res = s.FindNumberIn2DArray(matrix, 5);
        }

        public class Solution
        {
            public bool FindNumberIn2DArray(int[][] matrix, int target)
            {
                if (matrix.Length == 0 || matrix[0].Length == 0)
                {
                    return false;
                }

                int verticalIdx = 0;
                var m = matrix[0];

                if (m[0] == target || m[m.Length - 1] == target)
                {
                    return true;
                }

                for (int j = 0; j < m.Length; j++)
                {
                    if (m[j] == target)
                    {
                        return true;
                    }
                    else if (m[j] < target)
                    {
                        verticalIdx = j;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = 1; i < matrix.Length; i++)
                {
                    m = matrix[i];
                    if (m[verticalIdx] == target)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}