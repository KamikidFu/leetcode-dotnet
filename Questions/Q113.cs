using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeSolution.Structure;

namespace LeetCodeSolution.Questions
{
    public class Q113
    {
        public static void Run()
        {
            Solution s = new Solution();
            int sum = 2;
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(-2);
            root.left.left = new TreeNode(1);
            root.left.left.left = new TreeNode(-1);
            root.left.right = new TreeNode(3);
            root.right = new TreeNode(-3);
            root.right.left = new TreeNode(-2);
            var res = s.PathSum(root, sum);
        }


        public class Solution
        {
            private int sum;
            private IList<IList<int>> rtnList;

            public IList<IList<int>> PathSum(TreeNode root, int sum)
            {
                IList<int> path = new List<int>();
                this.rtnList = new List<IList<int>>();
                this.sum = sum;
                if (root == null)
                {
                    return this.rtnList;
                }

                path.Add(root.val);
                if (root.left == null && root.right == null)
                {
                    if (root.val == sum)
                    {
                        rtnList.Add(new List<int>(path));
                    }
                    return rtnList;
                }

                if (root.left != null)
                {
                    traverse(root.left, path);
                }

                if (root.right != null)
                {
                    traverse(root.right, path);
                }

                return rtnList;
            }

            private void traverse(TreeNode tree, IList<int> path)
            {
                path.Add(tree.val);
                if (tree.left == null && tree.right == null)
                {
                    if (path.Sum() == this.sum)
                    {
                        rtnList.Add(new List<int>(path));
                    }

                    path.RemoveAt(path.Count-1);
                    return;
                }

                if (tree.left != null)
                {
                    traverse(tree.left, path);
                }

                if (tree.right != null)
                {
                    traverse(tree.right, path);
                }

                path.RemoveAt(path.Count-1);
            }
        }
    }
}