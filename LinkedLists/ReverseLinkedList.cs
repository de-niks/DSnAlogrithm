using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class ReverseLinkedList
    {
        public ListNode ReverseDFS(ListNode head)
        {
            if (head == null)
                return null;


            ListNode globalHead = null;

            
            void Helper(ListNode h, ListNode p)
            {

                if (h.next == null)
                {
                    h.next = p;
                    globalHead = h;
                    return;
                }

                //recursive case 
                ListNode successor = h.next;
                h.next = p;
                Helper(successor, h);
            }


            Helper(head, null);

            return globalHead;

        }

        public ListNode ReverseInterative(ListNode head) 
        { 
            var current = head;
            ListNode predecessor = null;

            while (current != null)
            {
                ListNode successor = current.next;
                current.next = predecessor; 
                predecessor = current;
                current = successor;
            }

            return predecessor;

        }
    }
}
