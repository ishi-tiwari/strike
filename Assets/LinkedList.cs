using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList : MonoBehaviour
{
    Node head; 
    public class Node
    {
        public string data;
        public Node next;
        public Node(string d)
        {
            data = d;
            next = null;

        } 
    }
    public void printList()
    {
        Node n = head;
        while (n != null)
        {
            Debug.Log(n.data + " ");
            n = n.next;
        }
    }
    public static void Main()
    {
        
        LinkedList llist = new LinkedList();

        llist.head = new Node("Venu");
        Node second = new Node("Montu");
        Node third = new Node("Bhavesh");


        llist.head.next = second;
        second.next = third;

        llist.printList();
    }
    void Start()
    {
        //Main();
    }
    void entering_Data()
    {

    }
}