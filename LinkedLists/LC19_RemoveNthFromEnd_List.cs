using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class LC19_RemoveNthFromEnd_List
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var sentinel = new ListNode(Int32.MinValue , head);

            var leader = sentinel;

            //move the leader Nth nodes ahead
            for (int i = 0; i < n; i++)
                leader = leader.next;

            var follower = sentinel;

            ListNode predecessor = null;

            while (leader != null) { 

                leader = leader.next;
                predecessor = follower;
                follower = follower.next;
            
            }
            // Assign predecessor to next of follower which is node to be deleted
            //Follower is the node to be deleted as it is Nth steps behind leader
            predecessor.next = follower.next;

            head = sentinel.next;

            return head;
        }
    }
}
