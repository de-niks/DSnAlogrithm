using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class LLHasCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;

            ListNode hare = head;
            ListNode tortoise = head;

            while (hare.next != null && hare.next.next != null)
            {
                tortoise = tortoise.next;
                hare = hare.next.next;

                if (hare == tortoise)
                    return true;

            }

            return false;



        }


        public ListNode HasCycleII(ListNode head)
        {
            if (head == null)
                return null;

            ListNode hare = head;
            ListNode tortoise = head;

            while (hare.next != null && hare.next.next != null)
            {
                tortoise = tortoise.next;
                hare = hare.next.next;

                if (hare == tortoise)
                {
                    ListNode count = head;

                    while (tortoise != count)
                    {
                        count = count.next;
                        tortoise = tortoise.next;
                    }

                    return count;

                }

            }

            return null;
        }
    }
}
