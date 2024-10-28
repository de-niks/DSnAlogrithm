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

        public ListNode ReverseInterativeII(ListNode head, int left, int right)
        {
            var sentinelNode = new ListNode(int.MinValue, head);

            var current = head;
            int index = 1;
            var predecessor = sentinelNode;
            while (index != left)
            {
                predecessor = current;

                current = current.next;

                index++;
            }

            // cut the link before sub list starts 
            predecessor.next = null;

            var tail_left = predecessor;
            predecessor = null;

            var tail_middle = current;

            //keep rversing the sublist
            while (index != right + 1)
            {
                ListNode successor = current.next;
                current.next = predecessor;
                predecessor = current;
                current = successor;
                index++;
            }

            var head_middle = predecessor;
            var head_right = current;

            tail_left.next = head_middle;
            tail_middle.next = head_right;


            return sentinelNode.next;


            /* if (head == null || left == right) 
                 return head;

             ListNode dummy = new ListNode(0);
             dummy.next = head;
             ListNode prev = dummy;

             for (int i = 0; i < left - 1; ++i)
             {
                 prev = prev.next;
             }

             ListNode current = prev.next;

             for (int i = 0; i < right - left; ++i)
             {
                 ListNode nextNode = current.next;
                 current.next = nextNode.next;
                 nextNode.next = prev.next;
                 prev.next = nextNode;
             }

             return dummy.next;*/

        }
    }
}
