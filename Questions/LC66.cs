namespace LeetCodeSolution.Questions
{
    public class LC66
    {
        public static void Run()
        {
            Solution s = new Solution();
            var res = s.ConstructArr(new []{1,2,3,4,5});
            
        }
        public class Solution {
            public int[] ConstructArr(int[] a) {
                int[] res= new int[a.Length];
                int left = 1;
                for (int i = 0; i < a.Length; i++)
                {
                    res[i] = left;
                    left *= a[i];
                }

                int right = 1;
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    res[i] *= right;
                    right *= a[i];
                }

                return res;
            }
        }
    }
}