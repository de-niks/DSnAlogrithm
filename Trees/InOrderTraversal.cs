using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class InOrderTraversal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> Traversal(TreeNode root)
        {
            if (root == null)
                return new List<int>();

            var result = new List<int>();

            dfs(root, result);

            return result;
        }

        private void dfs(TreeNode root, List<int> result)
        {
            if (root.left == null && root.right == null)
            {
                result.Add(root.val);
                return;
            }

            if(root.left != null)
            {
                dfs(root.left, result);

            }

            result.Add(root.val);


            if (root.right != null)
            {
                dfs(root.right, result);
            }
        }
    }
}
