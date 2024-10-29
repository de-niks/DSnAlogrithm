using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class TreeNode
    {
        public int Key;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int key = 0, TreeNode left = null, TreeNode right = null)
        {
            this.Key = key;
            this.left = left;
            this.right = right;
        }
    }
}

