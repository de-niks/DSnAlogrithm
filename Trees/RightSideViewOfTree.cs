using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class RightSideViewOfTree
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> RightSideView(TreeNode root)
        {
            if(root ==  null)
                return new List<int>();


            var result = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();  

            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var qCount = queue.Count();

                var subResult = new List<int>();

                for (int i = 0; i < qCount; i++)
                { 
                    var popedNode = queue.Dequeue();

                    subResult.Add(popedNode.Key);

                    if(popedNode.left != null)
                    {
                        queue.Enqueue(popedNode.left);
                    }

                    if (popedNode.right != null)
                    {
                        queue.Enqueue(popedNode.right);
                    }
                }

                if (subResult.Count > 0)
                    result.Add(subResult.Last());
            }

            return result;
        }

        public IList<int> RightSideViewI(TreeNode root)
        {
            if (root == null)
                return new List<int>();


            var result = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var qCount = queue.Count();

                int subResult = 0;

                for (int i = 0; i < qCount; i++)
                {
                    var popedNode = queue.Dequeue();

                    subResult = popedNode.Key;

                    if (popedNode.left != null)
                    {
                        queue.Enqueue(popedNode.left);
                    }

                    if (popedNode.right != null)
                    {
                        queue.Enqueue(popedNode.right);
                    }
                }


                result.Add(subResult);
            }

            return result;
        }
    }
}
