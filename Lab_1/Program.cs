﻿using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList example = new SortedLinkedList();
            example.addItem(10);
            example.addItem(5);
            example.addItem(20);
            example.addItem(15);
            example.addItem(2);
            example.addItem(30);
            example.printList();
        }
    }
}