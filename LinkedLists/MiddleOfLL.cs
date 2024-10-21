using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class MiddleOfLL
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode hare = head;
            ListNode tortoise = head;

            while (hare != null && hare.next != null)
            {
                tortoise = tortoise.next;
                hare.next = hare.next.next;
            }

           

            return tortoise;
        }
    }
}
