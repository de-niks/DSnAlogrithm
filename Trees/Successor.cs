using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class Successor
    {
        public TreeNode FindSuccessor(TreeNode root, TreeNode p)
        {
            if (root == null)
                return null;

            /// if node has right subtree
            /// successor would be in the left sub tree
            /// of the node's right
            if (p.right != null)
            {
                var current = p.right;

                ///keep going to left 
                while (current.left != null)
                {
                    current = current.left;
                }
                ///return minimum in left 
                ///subtree which is successor
                return current;
            }


            TreeNode anscestor = null;
            
            var curr = root;
            while (curr.Key != p.Key)
            {
                if (p.Key < curr.Key)
                {
                    anscestor = curr;
                    curr = curr.left;
                }
                else
                {
                    curr = curr.right;
                }
            }

            return curr;


        }
    }
}
