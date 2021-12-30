using System;
using System.Collections.Generic;

class LinkedList
{
    public Node head;
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    public void push(int item)
    {
        Node Temp = new Node(item);
        Temp.next = head;
        head = Temp;
    }
    public static bool detectLoop(Node h)
    {
        HashSet<Node> s = new HashSet<Node>();
        while (h != null)
        {
            if (s.Contains(h))
                return true;

            s.Add(h);
            h = h.next;
        }

        return false;
    }

    public static void Main(String[] args)
    {
        LinkedList llist = new LinkedList();
        llist.push(20);
        llist.push(4);
        llist.push(15);
        llist.push(10);

        llist.head.next.next.next.next = llist.head;

        if (detectLoop(llist.head))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}