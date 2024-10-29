using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class SearchNode
    {
        public TreeNode Search(TreeNode root, int key)
        { 
            var current = root;
            while (current != null)
            {
                if (key == current.Key)
                {
                    return current;
                }
                else if (key < current.Key)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }

            }

            return current;
        
        }
    }
}
