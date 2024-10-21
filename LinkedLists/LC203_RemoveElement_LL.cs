using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class LC203_RemoveElement_LL
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var sentinal = new ListNode(int.MinValue,head);

            var predecessor = sentinal;
            var current = head;

            while (current != null)
            {
                if(current.val == val) // delete current node
                {
                    predecessor.next = current.next;
                    current = current.next;
                }
                else // move ahead in the list 
                {
                    predecessor = current;
                    current = current.next;

                }
            }

            head = sentinal.next;

            return head;

        }
    }
}
