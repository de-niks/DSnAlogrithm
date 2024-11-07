using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class ZigZagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();


            var result = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var rightToLeft = false;

            while (queue.Count != 0)
            {
                var temp = new List<int>();

                var qCount = queue.Count;

                for (int i = 0; i < qCount; i++)
                {
                    var popedNode = queue.Dequeue();

                    temp.Add(popedNode.Key);

                    if (popedNode.left != null)
                    {
                        queue.Enqueue(popedNode.left);
                    }

                    if (popedNode.right != null)
                    {
                        queue.Enqueue(popedNode.right);
                    }

                }

                if (rightToLeft)
                    temp.Reverse();

                result.Add(temp);

                rightToLeft = !rightToLeft;
            }

            return result;
        }
    }
}
