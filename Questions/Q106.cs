using System.Collections.Generic;
using LeetCodeSolution.Structure;

namespace LeetCodeSolution.Questions
{
    public class Q106
    {

        public static void Run()
        {
            int[] inorder = new[] {9, 3, 15, 20,7};
            int[] postorder = new[] { 9,15,7,20,3};
            Solution s = new Solution();
            var res = s.BuildTree(inorder,postorder);
        }

        public class Solution
        {
            private int postIdx;
            private int[] postOrder;
            private Dictionary<int, int> idxMap = new Dictionary<int, int>();
            
            public TreeNode BuildTree(int[] inorder, int[] postorder)
            {
                postOrder = postorder;
                postIdx = postorder.Length - 1;

                int idx = 0;
                foreach (var i in inorder)
                {
                    idxMap.Add(i,idx++);
                }

                return Helper(0, inorder.Length - 1);
            }

            private TreeNode Helper(int left, int right)
            {
                if (left > right)
                {
                    return null;
                }

                int curRootVal = postOrder[postIdx];
                TreeNode root = new TreeNode(curRootVal);

                int index = idxMap[curRootVal];

                postIdx--;
                root.right = Helper(index + 1, right);
                root.left = Helper(left, index - 1);

                return root;
            }
        }
    }
}