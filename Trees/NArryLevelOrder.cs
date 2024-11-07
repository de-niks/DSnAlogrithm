using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class NArryLevelOrder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrder(Node root)
        {
            if (root == null)
                return new List<IList<int>>();

            IList<IList<int>> result = new List<IList<int>>();
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count != 0)
            {

                var qCount = q.Count();

                var subResult = new List<int>();

                for (int i = 0; i < qCount; i++)
                {
                    var temp = q.Dequeue();

                    subResult.Add(temp.val);

                    foreach (Node child in temp.children)
                    {
                        q.Enqueue(child);
                    }
                }

                result.Add(subResult);

            }

            return result;
        }
    }
}
