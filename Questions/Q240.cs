namespace LeetCodeSolution.Questions
{
    public class Q240
    {
        public static void Run()
        {
            Solution s =new Solution();
            int[][] matrix = new int[1][];
            // matrix[0] = new[] {1, 4, 7, 11, 15};
            // matrix[1] = new[] {2, 5, 8, 12, 19};
            // matrix[2] = new[] {3, 6, 9, 16, 22};
            // matrix[3] = new[] {10, 13, 14, 17, 24};
            // matrix[4] = new[] {18, 21, 23, 26, 30};
            matrix[0] = new[] {-1,3};
            var res = s.FindNumberIn2DArray(matrix, 3);
        }
        public class Solution {
            public bool FindNumberIn2DArray(int[][] matrix, int target)
            {
                if (matrix.Length == 0 || matrix[0].Length == 0)
                {
                    return false;
                }
                
                int verticalIdx = 0;
                for (int i = 0; i < matrix.Length; i++)
                {
                    var m = matrix[i];
                    
                    if (m[0] == target || m[m.Length-1] == target)
                    {
                        return true;
                    }

                    if (m[verticalIdx] == target)
                    {
                        return true;
                    }
                    
                    if (m[0] < target && m[^1] > target)
                    {
                        for (int j = 0; j < m.Length; j++)
                        {
                            if (m[j] == target)
                            {
                                return true;
                            }else if (m[j] < target)
                            {
                                verticalIdx = j;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                return false;
            }
        }
    }
}