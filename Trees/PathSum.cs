using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if(root ==  null)
                return false;
            
            bool slate = false;

            DFS(root , targetSum , slate);

            return slate;
        }


        public void DFS(TreeNode node, int target, bool slate)
        {

            target -= node.Key;
            ///Base Case
            ///
            if(node.left == null && node.right == null)
            {
                if(target == 0)
                { 
                    slate = true;
                }

                return;
            }


            ///Recursive Case
            ///
            if(node.left != null)
            {
                DFS(node.left, target, slate);
            }

            if (node.right != null)
            {
                DFS(node.right, target, slate);
            }


        }
    }
}
