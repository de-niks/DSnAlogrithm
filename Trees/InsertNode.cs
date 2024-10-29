using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class InsertNode
    {
        public TreeNode Insert(TreeNode root, int key)
        {
            var newNode = new TreeNode(key);

            if (root == null)
                return newNode;

            var current = root;
            TreeNode previous = null;
            // Traversal 
            while (current != null)
            {
                if (current.Key == key)
                    throw new Exception("Key already exists");
                else if (key < current.Key)
                {
                    previous = current;
                    current = current.left;
                }
                else if (key > current.Key)
                {
                    previous = current;
                    current = current.right;
                }

            }

            if (key < previous.Key)
            {
                previous.left = newNode;
            }
            else
            {
                previous.right = newNode;   
            }

            return root;
        }
    }
}
