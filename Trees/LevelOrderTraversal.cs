using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class LevelOrderTraversal
    {
        /// <summary>
        /// TC : O(n)
        /// SC: O(n)
        /// Level order traversal using Queue
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();

            IList<IList<int>> result = new List<IList<int>>();
            System.Collections.Generic.Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {

                var qCount = q.Count();

                var subResult = new List<int>();

                for (int i = 0; i < qCount; i++)
                {
                    var temp = q.Dequeue();
                    subResult.Add(temp.Key);

                    if (temp.left != null)
                    {
                        q.Enqueue(temp.left);
                    }

                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                    }
                }

                result.Add(subResult);

            }

            return result;
        }
    }
}
