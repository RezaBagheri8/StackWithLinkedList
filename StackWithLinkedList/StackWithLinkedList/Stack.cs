using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithLinkedList
{
    public class Stack
    {
        public Node head;
        public Node top;

        public void Push(int value)
        {
            if (head == null)
            {
                Node newItem = new Node();
                newItem.value = value;
                head = newItem;
                top = newItem;
            }
            else
            {
                Node newItem = new Node();
                newItem.value = value;

                Node node = head;
                while (node.next != null)
                {
                    node = node.next;
                }

                node.next = newItem;
                top = newItem;
            }
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                Node node = head;

                if (node.next != null)
                {
                    while (node.next.next != null)
                    {
                        node = node.next;
                    }

                    Console.WriteLine(top.value);
                    top = null;
                    top = node;
                    top.next = null;
                }
                else
                {
                    Console.WriteLine(top.value);
                    top = null;
                    head = null;
                }
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                Node node = head;
                while (node != null)
                {
                    Console.WriteLine(node.value);
                    node = node.next;
                }
            }
        }

        public bool IsEmpty()
        {
            if (top == null || head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
