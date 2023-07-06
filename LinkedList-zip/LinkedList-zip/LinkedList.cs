using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_zip
{
    public class LinkedList
    {
        Node Head;
        Node Tail;
        public LinkedList()
        {
            Head = Tail = null;
        }

        public void Append(int value)
        {
            Node item = new Node(value);
            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
        }

        public static Node ZipLists(LinkedList list1, LinkedList list2)
        {
            if (list1.Head == null)
                return list2.Head;

            if (list2.Head == null)
                return list1.Head;

            Node current1 = list1.Head;
            Node current2 = list2.Head;
            Node next1, next2;

            while (current1 != null && current2 != null)
            {
                next1 = current1.Next;
                next2 = current2.Next;

                current2.Next = next1;
                current1.Next = current2;

                current1 = next1;
                current2 = next2;
            }

            if (current1 == null)
            {
                list1.Tail.Next = current2; 
                list1.Tail = list2.Tail; 
            }
            else
            {
                list1.Tail.Next = current1; 
            }

            return list1.Head;
        }

        public void PrintList(Node head)
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
