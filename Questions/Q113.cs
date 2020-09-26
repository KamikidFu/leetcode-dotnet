using System;
using System.Collections.Generic;
using LeetCodeSolution.Structure;

namespace LeetCodeSolution.Questions
{
    public class Q113
    {
        public static void Run()
        {
            Solution s = new Solution();
            int sum = 22;
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.left.left = new TreeNode(11);
            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(2);
            root.right = new TreeNode(8);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);
            root.right.right.left = new TreeNode(5);
            root.right.right.right = new TreeNode(1);
            var res = s.PathSum(root, sum);
        }
        

        public class Solution {
            public IList<IList<int>> PathSum(TreeNode root, int sum) {
                throw new NotImplementedException();
            }
        }
    }
}