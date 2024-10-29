using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class Minimum
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int FindMinimum(TreeNode root)
        { 
            var curr = root;
            // keep travelling left as smallest value will be in the left subtree 
            while (curr != null && curr.left != null)
            {
                curr = curr.left;   
            }

            return curr.Key;
        }
    }
}
