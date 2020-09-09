using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolution.Questions
{
    public class Q1389
    {
        public static void Run(int[] nums, int[] index)
        {
            Solution s = new Solution();
            Array.ForEach(s.CreateTargetArray(nums, index), Console.WriteLine);
        }

        public class Solution
        {
            public int[] CreateTargetArray(int[] nums, int[] index)
            {
                // int[] target = new int[nums.Length];
                // for (int i = 0; i < target.Length; i++)
                // {
                //     target[i] = -1;
                // }
                //
                // for (int i = 0; i < index.Length; i++)
                // {
                //     ArrayInsertAt(target, index[i], nums[i]);
                // }
                //
                // return target;
                List<int> list = new List<int>();
                for (int i = 0; i < nums .Length ; i++)
                {
                    if (index [i]>list .Count )
                    {
                        list.Add(nums[i]);
                    }
                    else if (index [i]<=list .Count )
                    {
                        list.Insert(index[i], nums[i]);
                    }
                }
                int[] result = list.ToArray();
                return result;
            }

            public void ArrayInsertAt(int[] nums, int index, int num)
            {
                if (nums[index] == -1)
                {
                    nums[index] = num;
                    return;
                }

                if (index < nums.Length && index > -1)
                {
                    int pre = nums[index];
                    int cur = nums[index];
                    for (int i = index; i < nums.Length; i++)
                    {
                        if (nums[i + 1] == -1)
                        {
                            nums[i + 1] = pre;
                            break;
                        }
                        else
                        {
                            cur = nums[i + 1];
                            nums[i + 1] = pre;
                            pre = cur;
                        }
                    }
                }
                else
                {
                    return;
                }

                nums[index] = num;
            }
        }
    }
}