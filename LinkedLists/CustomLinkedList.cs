using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class CustomListnode
    {
        private int value;
        private CustomListnode next;
        private CustomListnode head = null;
        private CustomListnode tail = null;

          public CustomListnode(int val, CustomListnode next) {
            this.value = val;
            this.next = next;   
        }

        public CustomListnode() {

            this.head = null;
            this.tail = null;

        }

        internal CustomListnode Head { get => head; set => head = value; }
        internal CustomListnode Tail { get => tail; set => tail = value; }
        internal CustomListnode Next { get => next; set => next = value; }

        public int Get(int index)
        {
            var current = head;

            int nodeIdx = 0;
            // iterate 
            while (current != null && nodeIdx != index)
            {
                current = current.next;
                nodeIdx++;
            }

            if (current != null)
                return current.value;
            else return -1;

        }

        public void AddAtHead(int val)
        {
            var newNode = new CustomListnode();
            newNode.value = val;
            this.Head = newNode;

            if (this.Tail == null)
                this.Tail = newNode;
        }

        public void AddAtTail(int val)
        {
            var newNode = new CustomListnode(val, null);
            if (this.head == null)
            {
                this.Head= newNode;
                this.Tail= newNode;

            }
            else
            {
                this.Tail.next = newNode;
                this.Tail = newNode;
            }
           
        }

        public void AddAtIndex(int index, int value)
        {

            CustomListnode current = head;
            CustomListnode predecessor = null;
            CustomListnode sentinal = new CustomListnode(int.MinValue, head);
            int nodeIdx = 0;
            // iterate 
            while (current != null && nodeIdx != index)
            {
                predecessor = current;
                current = current.next;
                nodeIdx++;
            }


            CustomListnode nodeToAdd = new CustomListnode(value, null);

            if (current != null)
            {
                predecessor.Next = nodeToAdd;
                nodeToAdd.next = current;
            }
            else if (nodeIdx == index)
            {
                predecessor.Next = nodeToAdd;
                this.Tail = nodeToAdd;
            }

            head = sentinal.Next;
        }

        public void RemoveAt(int index)
        {

            CustomListnode current = head;
            CustomListnode predecessor = null;
            CustomListnode sentinal = new CustomListnode(int.MinValue, head);
            int nodeIdx = 0;
            // iterate 
            while (current != null && nodeIdx != index)
            {
                predecessor = current;
                current = current.next;
                nodeIdx++;
            }

        }



    }
}
