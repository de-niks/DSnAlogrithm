using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class DiameterofBinaryTree
    {
        public int DiameterOfTree(TreeNode root)
        {
            if(root == null)
                return 0;

            int globalBox = 0;

            DFS(root , globalBox);

            return globalBox;

        }

        private int DFS(TreeNode node , int globalBox)
        {
            if (node.left == null && node.right == null)
                return 0;

            int lheight = 0;
            int rheight = 0;
            int myDia = 0;

            if (node.left != null)
            {
                lheight = DFS(node.left , globalBox);
                myDia += lheight + 1;
            }

            if (node.right != null)
            {
                rheight = DFS(node.right, globalBox);
                myDia += rheight + 1;
            }

            globalBox = Math.Max(globalBox, myDia);

            return Math.Max(lheight, rheight) + 1;

        }
    }
}
