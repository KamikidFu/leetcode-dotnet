using System.Runtime.InteropServices;
using LeetCodeSolution.Structure;

namespace LeetCodeSolution.Questions
{
    public class Q117
    {
        public static void Run()
        {
            Solution s = new Solution();
            Node root = new Node(1);
            root.left = new Node(2);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right = new Node(3);
            root.right.right = new Node(7);
            var res = s.Connect(root);
        }

        public class Solution
        {
            private Node last = null, nextStart = null;
            public Node Connect(Node root)
            {
                if (root == null)
                {
                    return null;
                }

                Node start = root;
                while (start!=null)
                {
                    last = null;
                    nextStart = null;
                    for (Node p = start; p != null; p = p.next)
                    {
                        if (p.left != null)
                        {
                            Handle(p.left);
                        }
                        if (p.right != null)
                        {
                            Handle(p.right);
                        }
                    }

                    start = nextStart;
                }

                return root;
            }

            private void Handle(Node p)
            {
                if (last != null)
                {
                    last.next = p;
                }

                if (nextStart == null)
                {
                    nextStart = p;
                }

                last = p;
            }
        }
    }
}