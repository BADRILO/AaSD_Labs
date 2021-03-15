﻿using System;

namespace Lab_1
{
    class SortedLinkedList
    {
        private int len;
        private Node first;

        public SortedLinkedList()
        {
            this.len = 0;
            this.first = null;
        }
        public void addItem(int item)
        {
            if (len == 0 || item < first.Data)
            {
                Node node = new Node(item, first);
                first = node;
                len++;
            }
            else
            {
                Node lower_node  = first;
                Node bigger_node = first.Next;

                while (true)
                {
                    if (bigger_node == null || item < bigger_node.Data)
                    {
                        Node node = new Node(item, bigger_node);
                        lower_node.Next = node;
                        len++;
                        break;
                    }
                    bigger_node = bigger_node.Next;
                    lower_node = lower_node.Next;
                }
            }
        }
        public void printList()
        {
            Node pointer = first;
            for (int i = 1; pointer != null;)
            {
                Console.WriteLine($"Node №{i++}: {pointer.Data}");
                pointer = pointer.Next;
            }
        }
    }
}