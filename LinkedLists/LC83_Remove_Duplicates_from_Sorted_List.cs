using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class LC83_Remove_Duplicates_from_Sorted_List
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var sentinal = new ListNode(int.MinValue, head);

            var predecessor = sentinal;
            var current = head;

            while (current != null)
            {
                if (current.val == predecessor.val) // Delete Node if pred value match as list is sorted
                {
                    predecessor.next = current.next;
                    current = current.next;
                }
                else 
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
