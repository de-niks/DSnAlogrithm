using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class SwapNodes
    {
        public ListNode SwapNodesLL(ListNode head, int k)
        {
            var current = head;

            int index = 1;
            while (index < k)
            {
                current = current.next;
                index++;
            }

            var tempNode = current;

            var hare = current;
            var tortoise = head;
            while (hare != null && hare.next != null)
            {
                hare = hare.next;
                tortoise = tortoise.next;
            }
            var temp = tempNode.val;
            tempNode.val = tortoise.val;
            tortoise.val = temp;


            return head;

        }
    }
}
