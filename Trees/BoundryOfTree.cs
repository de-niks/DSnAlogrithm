using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class BoundryOfTree
    {

        public IList<int> BoundaryOfBinaryTree(TreeNode root)
        {
            IList<int> result = new List<int>();

            result.Add(root.val);
            LeftBoubndry(root.left, result);
            Leaf(root.left, result);
            Leaf(root.right, result);
            RightBoundry(root.right, result);

            return result;

        }


        public void LeftBoubndry(TreeNode node, IList<int> result)
        {
            if (node == null || (node.left == null && node.right == null))
                return;

            result.Add(node.val); // pre-order traversal 

            if (node.left != null)
                LeftBoubndry(node.left, result);
            else
                LeftBoubndry(node.right, result);
        }

        public void RightBoundry(TreeNode node, IList<int> result)
        {
            if (node == null || (node.left == null && node.right == null))
                return;

            if (node.right != null)
            {

                RightBoundry(node.right, result);
            }
            else
            {
                RightBoundry(node.left, result);
            }

            result.Add(node.val);
        }

        public void Leaf(TreeNode node, IList<int> result)
        {
            if (node != null)
                return;

            if (node.left == null && node.right == null)
            {
                result.Add(node.val);
            }

            Leaf(node.left, result);
            Leaf(node.right, result);
        }
    }



}

