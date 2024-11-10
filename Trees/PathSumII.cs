using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class PathSumII
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            IList<IList<int>> result = new List<IList<int>>();  

            List<int> interimSlate = new List<int>();

            if (root != null)
                dfs(root, targetSum, interimSlate, result);


            return result;


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="targetSum"></param>
        /// <param name="interimSlate"></param>
        /// <param name="result"></param>
        private void dfs(TreeNode node, int targetSum, List<int> interimSlate, IList<IList<int>> result)
        {

            if (node == null)
                return;


            targetSum -= node.val;
            interimSlate.Add(node.val);

            if (node.left == null && node.right == null)
            {
                if (targetSum == 0)
                {
                    result.Add(interimSlate.ToList());
                }

                interimSlate.RemoveAt(interimSlate.Count - 1);

                return;
            }


            if (node.left != null)
            {
                dfs(node.left, targetSum, interimSlate, result);
            }

            if (node.right != null)
            {
                dfs(node.right, targetSum, interimSlate, result);
            }

            interimSlate.RemoveAt(interimSlate.Count - 1);
        }


    }
}
