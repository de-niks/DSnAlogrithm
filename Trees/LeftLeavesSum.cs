using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class LeftLeavesSum
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            if(root == null) 
                return 0;  

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            int sum = 0;

            while (stack.Count != 0)
            {
                var node = stack.Pop();

                if (node.left != null)
                {
                    if (node.left.left == null && node.left.right == null)
                    {
                        sum += node.left.val;
                    }

                    stack.Push(node.left);
                }

                if (node.right != null)
                {
                    stack.Push(node.right);
                }
            }

            return sum;

        }
    }
}
