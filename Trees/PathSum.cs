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
            if (root == null)
                return false;


            targetSum -= root.val;


            if (root.left == null && root.right == null)
            {
                return (targetSum == 0);
            }

            bool lflag = false;
            bool rflag = false;



            if (root.left != null)
            {
                lflag = HasPathSum(root.left, targetSum);
            }

            if (root.right != null)
            {
                rflag = HasPathSum(root.right, targetSum);
            }

            return lflag || rflag;
        }
    }
}
