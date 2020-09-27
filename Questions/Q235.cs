using System;
using LeetCodeSolution.Structure;

namespace LeetCodeSolution.Questions
{
    public class Q235
    {
        public static void Run()
        {
            Solution s = new Solution();
            TreeNode root = new TreeNode(2);
            TreeNode p = new TreeNode(2);
            TreeNode q = new TreeNode(1);
            root.left = new TreeNode(1);
            // root.right = new TreeNode(8);
            // root.left.left = new TreeNode(0);
            // root.left.right = new TreeNode(4);
            // root.left.right.left = new TreeNode(3);
            // root.left.right.right = new TreeNode(5);
            // root.right.left = new TreeNode(7);
            // root.right.right = new TreeNode(9);
            var res = s.LowestCommonAncestor(root, p, q);
        }

        public class Solution
        {
            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {
                if (root.left.val == p.val && root.right.val == q.val)
                {
                    return root;
                }

                if (p.val < root.val && q.val > root.val)
                {
                    return root;
                }

                if (p.val < root.val && q.val < root.val)
                {
                    return LowestCommonAncestor(root.left, p, q);
                }

                if (p.val > root.val && q.val > root.val)
                {
                    return LowestCommonAncestor(root.right, p, q);
                }

                if (p.val == root.val && (q.val == root.right.val || q.val == root.left.val))
                {
                    return p;
                }

                if (q.val == root.val && (p.val == root.right.val || p.val == root.left.val))
                {
                    return q;
                }

                return null;
            }
        }
    }
}