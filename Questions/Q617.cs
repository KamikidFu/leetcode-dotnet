using LeetCodeSolution.Structure;

namespace LeetCodeSolution.Questions
{
    public class Q617
    {
        public static void Run()
        {
            // TreeNode t1 = new TreeNode(1);
            // t1.left = new TreeNode(3);
            // t1.left.left = new TreeNode(5);
            // t1.right = new TreeNode(2);
            // TreeNode t2 = new TreeNode(2);
            // t2.left = new TreeNode(1);
            // t2.left.right = new TreeNode(4);
            // t2.right = new TreeNode(3);
            // t2.right.right = new TreeNode(7);
            TreeNode t1 = null;
            TreeNode t2 = null;
            Solution s = new Solution();
            var t3 = s.MergeTrees(t1, t2);
        }

        public class Solution
        {
            public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
            {
                // TreeNode rtn = new TreeNode(0);
                // if (t1 != null && t2 != null)
                // {
                //     rtn = new TreeNode(t1.val + t2.val);
                // }else if (t1 == null && t2 != null)
                // {
                //     rtn = new TreeNode(t2.val);
                //     return rtn;
                // }else if (t1 != null && t2 == null)
                // {
                //     rtn = new TreeNode(t1.val);
                //     return rtn;
                // }
                // else
                // {
                //     return null;
                // }
                //
                // if (t1.left != null && t2.left != null)
                // {
                //     rtn.left = MergeTrees(t1.left, t2.left);
                // }
                //
                // if (t1.right != null && t2.right != null)
                // {
                //     rtn.right = MergeTrees(t1.right, t2.right);
                // }
                //
                // if (t1.left != null && t2.left == null)
                // {
                //     rtn.left = MergeTrees(t1.left, new TreeNode(0));
                // }
                //
                // if (t1.left == null && t2.left != null)
                // {
                //     rtn.left = MergeTrees(new TreeNode(0), t2.left);
                // }
                //
                // if (t1.right != null && t2.right == null)
                // {
                //     rtn.right = MergeTrees(t1.right, new TreeNode(0));
                // }
                //
                // if (t1.right == null && t2.right != null)
                // {
                //     rtn.right = MergeTrees(new TreeNode(0), t2.right);
                // }
                //
                // return rtn;
                if (t1 == null)
                {
                    return t2;
                }

                if (t2 == null)
                {
                    return t1;
                }

                t1.val += t2.val;
                t1.left = MergeTrees(t1.left, t2.left);
                t1.right = MergeTrees(t1.right, t2.right);
                return t1;
            }
        }
    }
}