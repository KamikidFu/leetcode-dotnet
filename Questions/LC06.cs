using System.Collections.Generic;
using LeetCodeSolution.Structure;

namespace LeetCodeSolution.Questions
{
    public class LC06
    {
        public static void Run()
        {
            Solution s = new Solution();
            ListNode h = new ListNode(1);
            h.next = new ListNode(3);
            h.next.next = new ListNode(2);
            var res = s.ReversePrint(h);
        }

        public class Solution
        {
            public int[] ReversePrint(ListNode head)
            {
                List<int> list = new List<int>();
                while (head != null)
                {
                    list.Add(head.val);
                    head = head.next;
                }

                list.Reverse();
                var res = list.ToArray();
                return res;
            }
        }
    }
}