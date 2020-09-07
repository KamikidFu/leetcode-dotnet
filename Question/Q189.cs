using System;
using System.Text;

namespace ConsoleApplication1.Question
{
    public class Q189
    {
        public static void Run(int[] nums, int k)
        {
            Solution s = new Solution();
            s.Rotate(nums,k);
        }
        public class Solution {
            public void Rotate(int[] nums, int k)
            {
                if (k == 0) return;
                k %= nums.Length;
                // for (int i = 0; i < k; i++)
                // {
                //     var last = nums[nums.Length-1];
                //     for (int j = nums.Length-1; j > 0; j--)
                //     {
                //         nums[j] = nums[j - 1];
                //     }
                //     nums[0] = last;
                // }
                
                //1,2,3,4,5,6,7;3 -> 5,6,7,1,2,3,4
                //7,6,5,4,3,2,1;
                //5,6,7,1,2,3,4
                
                Reverse(nums,0,nums.Length-1);
                Reverse(nums,0,k-1);
                Reverse(nums,k,nums.Length-1);
            }

            public void Reverse(int[] nums, int start,int end)
            {
                while (start < end)
                {
                    int temp = nums[start];
                    nums[start++] = nums[end];
                    nums[end--] = temp;
                }
            }

            
        }
    }
}