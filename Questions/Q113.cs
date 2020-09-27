using System;
using System.Collections.Generic;
using LeetCodeSolution.Structure;

namespace LeetCodeSolution.Questions
{
    public class Q113
    {
        private IList<IList<int>> rtnList;
        public static void Run()
        {
            rtnList = new List<List<int>>();
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
                IList<int> path = new List<int>();
                if(root == null){
                    return null;
                }
                if(root.left == null && root.right == null){
                    path.add(root.val);
                    rtnList.add(path);
                    return rtnList;
                }
                if(root.left != null){
                    traverse(root.left, path);
                }
                if(root.right != null){
                    traverse(root.right, path);
                }
                return rtnList;
            }
            private void traverse(TreeNode tree, IList<int> path){
                    path.add(tree.val);
                if(tree.left == null && tree.right == null){
                    rtnList.add(path);
                    return;
                }
                if(tree.left != null){
                    traverse(tree.left, path);
                }
                if(tree.right != null){
                    traverse(tree.right,path);
                }
            }
        }
    }
}