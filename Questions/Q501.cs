using System.Collections.Generic;
using LeetCodeSolution.Structure;

namespace LeetCodeSolution.Questions
{
    public class Q501
    {
        public static void Run()
        {
            Solution s = new Solution();
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(1);
            root.left.right = new TreeNode(1);
            root.left.left = new TreeNode(1);
            root.right=new TreeNode(2);
            var result = s.FindMode(root);
        }
        

        public class Solution
        {
            int _base, count, maxCount;
            List<int> rtn = new List<int>();

            public int[] FindMode(TreeNode root)
            {
                TreeNode cur = root, pre = null;
                // Inorder Traversal 中序遍历
                while (cur != null)
                {
                    if (cur.left == null)
                    {
                        Update(cur.val);
                        cur = cur.right;
                        continue;
                    }

                    
                    pre = cur.left;
                    while (pre.right != null && pre.right != cur)
                    {
                        pre = pre.right;
                    }

                    if (pre.right == null)
                    {
                        pre.right = cur;
                        cur = cur.left;
                    }
                    else
                    {
                        pre.right = null;
                        Update(cur.val);
                        cur = cur.right;
                    }
                }

                int[] mode = new int[rtn.Count];
                for (int i = 0; i < rtn.Count; ++i)
                {
                    mode[i] = rtn[i];
                }

                return mode;
            }

            private void Update(int x)
            {
                if (x == _base)
                {
                    ++count;
                }
                else
                {
                    count = 1;
                    _base = x;
                }

                if (count == maxCount)
                {
                    rtn.Add(_base);
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    rtn.Clear();
                    rtn.Add(_base);
                }
            }
        }
    }
}