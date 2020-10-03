namespace LeetCodeSolution.Questions
{
    public class LC21
    {
        public static void Run()
        {
            Solution s = new Solution();
            var res = s.Exchange(new []{1,2,3,4});
        }
        public class Solution {
            public int[] Exchange(int[] nums)
            {
                
                // int odd = 0;
                // int even = nums.Length - 1;
                // int[] rtn = new int[nums.Length];
                // foreach (var num in nums)
                // {
                //     if ((num & 1) == 0)
                //     {
                //         rtn[even] = num;
                //         even--;
                //     }
                //     else
                //     {
                //         rtn[odd] = num;
                //         odd++;
                //     }
                // }
                //
                // return rtn;

                int start = 0;
                int end = nums.Length - 1;
                while (start < end)
                {
                    while (start < end && (nums[start] & 1) != 0)
                    {
                        start++;
                    }
                    while (start < end && (nums[end] & 1) == 0)
                    {
                        end--;
                    }

                    int temp = nums[start];
                    nums[start] = nums[end];
                    nums[end] = temp;
                }

                return nums;
            }
        }
    }
}