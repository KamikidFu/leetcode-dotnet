using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolution.Questions
{
    public class Q1389
    {
        public static void Run(int[] nums, int[] index){
            Solution s = new Solution();
            Console.WriteLine(s.CreateTargetArray(nums, index));
        }

        public class Solution {
            public int[] CreateTargetArray(int[] nums, int[] index) {
                int[] target = new int[nums.Length];
                for(int i = 0; i < target.Length;i++){
                    target[i] = -1;
                }

                for(int i = 0; i < index.Length; i++){
                    ArrayInsertAt(target, index[i], nums[i]);
                }
                
                return target;
            }

            public void ArrayInsertAt(int[] nums, int index, int num){
                if(nums[index] == -1){
                    nums[index] = num;
                    return;
                }
                if(index < nums.Length && index > -1){
                    int temp = 0;
                    for(int i = index + 1, i < nums.Length; i++){
                        if(nums[i] == -1){
                            nums[i] = temp;
                            break;
                        }else{
                            temp = nums[i+1];
                            nums[i+1] = nums[i];
                        }
                    }
                }else{
                    return;
                }
                nums[index] = num;
            }
        }
    }
}