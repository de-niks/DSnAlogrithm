using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class LC82_Remove_Duplicates_from_Sorted_List_II
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode sentinal = new ListNode(Int32.MinValue, head);
            ListNode curr = sentinal;
            ListNode predecessor = sentinal;
            while (curr != null && curr.next != null)
            {
                int val = curr.val;
                ListNode messanger = curr;
                while (messanger.next != null && messanger.next.val == val)
                {
                    messanger = messanger.next;
                }
                
                if (curr != messanger)
                {
                    predecessor.next = messanger.next;
                    curr = messanger.next;
                }
                else
                {
                    predecessor = curr;
                    curr = messanger.next;
                }
            }
            return sentinal.next;



        }
    }
}
