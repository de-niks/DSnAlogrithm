using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class LC1474_Delete_M_Nodes_After_N_Nodes
    {
        public ListNode DeleteNodes(ListNode head, int m, int n)
        { 
            var sentinel = new ListNode(Int32.MinValue, head);

            var current = head;

            ListNode predecessor = sentinel;

            while (current != null)
            {
                int index = 1;

                while (current != null && index <= m)
                {
                    predecessor = current;  
                    current =   current.next;
                    index++;
                }

                if(current == null)
                    break;


                index = 1;

                var messanger = current;
                while (messanger != null && index <= n)
                { 
                    messanger = messanger.next; 
                    index++;
                }

                predecessor.next = messanger;
                current = messanger;

            }


            return sentinel.next;
        }
    }
}
