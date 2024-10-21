using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class AddingTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            int carry = 0;
            while (l1 != null || l2 != null || carry != 0)
            { 
                int val1 = l1 == null ? 0 : l1.val;
                int val2 =  l2 == null ? 0 : l2.val;

                int val = val1 + val2 + carry;

                carry = val1 + val2 / 10;

                val = val % 10;

                current.next = new ListNode(val);

                l1 = (l1 != null) ? l1.next : null;
                l2 = (l2 != null) ? l2.next : null;
            }

            return dummy.next;

        }


    }
}
